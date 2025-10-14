
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviors : MonoBehaviour
{
   

    //1
    public float MoveSpeed = 10f;

    public float RotateSpeed = 75f;



    private float _vInput;

    private float _hInput;
    private Rigidbody _rb;

  //2
    void Start()
    {
        //3 
        _rb = GetComponent<Rigidbody>();
    }
  

    // Update is called once per frame 
    //4
    void Update()
    {
        
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
        //2
        Vector3 rotation = Vector3.up*_hInput;
        //3
        Quaternion angleRot = Quaternion.Euler(rotation*Time.fixedDeltaTime);
        //4
        _rb.MovePosition(this.transform.position + this.transform.forward* _vInput* Time.fixedDeltaTime);
        //5
        _rb.MoveRotation(_rb.rotation * angleRot);
    }
}
