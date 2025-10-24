
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviors : MonoBehaviour
{


    public GameObject Bullet;
    public float BulletSpeed = 100f;


    private bool _isShooting;


    public float DistanceToGround = 0.1f;
    
   
    
    private CapsuleCollider _col;

   

    public float JumpVelocity = 5f; //ch8 code

    private bool _isJumping;

    

    public float MoveSpeed = 10f;

    public float RotateSpeed = 75f;

    public LayerMask GroundLayer;

    private float _vInput;

    private float _hInput;
    private Rigidbody _rb;

  
    void Start()
    {
        
        _rb = GetComponent<Rigidbody>();

        //4
        _col = GetComponent<CapsuleCollider>();

    }
  

    // Update is called once per frame 
    //4
    void Update()
    {

        _isShooting |= Input.GetKeyDown(KeyCode.P);

        _isJumping |= Input.GetKeyDown(KeyCode.Space);
        
    _vInput = Input.GetAxis("Vertical")*MoveSpeed;

   
    _hInput = Input.GetAxis("Horizontal")*RotateSpeed;

    /*

    this.transform.Translate(Vector3.forward*_vInput*Time.deltaTime);
    //6
    this.transform.Rotate(Vector3.up*_hInput*Time.deltaTime);
    */
    }
    //1
    void FixedUpdate()
    {
      
        Vector3 rotation = Vector3.up*_hInput;

        if (IsGrounded() && _isJumping)
        {
            _rb.AddForce(Vector3.up * JumpVelocity, ForceMode.Impulse);
        }
        
        _isJumping = false;



       /*  if (_isJumping)  //commed out bcuz it creates a logic error in Grounded Code
        {
            _rb.AddForce(Vector3.up * JumpVelocity, ForceMode.Impulse);
        } */
        
       

        Quaternion angleRot = Quaternion.Euler(rotation*Time.fixedDeltaTime);
        
        _rb.MovePosition(this.transform.position + this.transform.forward* _vInput* Time.fixedDeltaTime);
       
        _rb.MoveRotation(_rb.rotation * angleRot);



        

        if(_isShooting)
        {
            GameObject newBullet = Instantiate(Bullet,
                this.transform.position + new Vector3(0, 0, 1),
                this.transform.rotation);


            Rigidbody BulletRB = 
                newBullet.GetComponent<Rigidbody>();
            BulletRB.linearVelocity = this.transform.forward * BulletSpeed;

        }
        _isShooting = false;    


    }




    private bool IsGrounded()
    {
      
        Vector3 capsuleBottom = new Vector3(_col.bounds.center.x,
            _col.bounds.min.y, _col.bounds.center.z);

        bool grounded = Physics.CheckCapsule(_col.bounds.center,
            capsuleBottom, DistanceToGround, GroundLayer,
            QueryTriggerInteraction.Ignore);
        
        return grounded;
    }
}
