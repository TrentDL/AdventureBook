using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviors : MonoBehaviour
{
  // 1

  public GameBehaviors GameManager;

  void Start()
    {
        GameManager = GameObject.Find("GameManager").GetComponent<GameBehaviors>();
    }

  void OnCollisionEnter(Collision collision)
  {
    // 2
    if(collision.gameObject.name == "Player")
    {
        // 3
        Destroy(this.gameObject); //my itemBehaviors script is not a parent of Health_pickup
      // 4
      Debug.Log("Item collected!");
        
        GameManager.Items += 1;

        GameManager.PrintLootReport();
    }
  }
}
