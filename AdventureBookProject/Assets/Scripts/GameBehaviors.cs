using UnityEngine;

public class GameBehaviors : MonoBehaviour
{
    private int _itemsCollected = 0;

    private int _playerHP = 10;


   

    
    public int Items
    {
        get { return _itemsCollected; }

        set
        {
            _itemsCollected = value;
            Debug.LogFormat("Items: {0}", _itemsCollected);
        }
    }
    

    public int HP
    {
        get { return _playerHP; }
        
        set
        {
            _playerHP = value;
            Debug.LogFormat("Lives: {0}", _playerHP);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        
        


    }
    



}
