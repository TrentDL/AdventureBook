using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class EnemyBehaviors : MonoBehaviour
{
    public Transform PatrolRoute;

    public List<Transform> Locations; //ch 9,pg 436 "for review"

    private int _locationIndex = 0;

    private NavMeshAgent _agent;

    public Transform Player;

    private int _lives = 3;

    public int EnemyLives
    {
        get { return _lives; }

        private set
        {
            _lives = value;
            if (_lives <= 0)
            {
                Destroy(this.gameObject);
                Debug.Log("Enemy down.");
            }
        }
    }

    void Start()
    {
         Player = GameObject.Find("Player").transform;
        _agent = GetComponent<NavMeshAgent>();
        InitializePatrolRoute();
        MoveToNextPatrolLocation();
       
    }//end of function >:)



    void Update()
    {
        if(_agent.remainingDistance < 0.2f && !_agent.pathPending) //ch9, pg.439
        {
            MoveToNextPatrolLocation();
        }
    }//end of function >:)



    void OnTriggerEnter(Collider other)
   {
  
    if(other.name == "Player")
    {
        _agent.destination = Player.position;
        Debug.Log("Player detected - attack!");
    }


   } //end of function >:)








    void InitializePatrolRoute()
    {
        foreach(Transform child in PatrolRoute)
        {
            Locations.Add(child);
        }
    } //end of function >:)

    void MoveToNextPatrolLocation()
    {
        if (Locations.Count == 0)
        return;

        _agent.destination = Locations[_locationIndex].position;
        
        _locationIndex = (_locationIndex + 1) % Locations.Count;

    } //end of function >:)


   void OnTriggerExit(Collider other)
   {
   
    if(other.name == "Player")
    {
        Debug.Log("Player out of range, resume patrol");
    }

   } //end of function >:)


   void OnCollisionEnter(Collision collision)
   {
    if(collision.gameObject.name == "Bullet(Clone)")
    {
        EnemyLives -= 1;
        Debug.Log("Critical hit!");
    }  
   }//end of function >:)
}
