using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody body;
    
    private float horizontal, vertical;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        Cursor.visible = false;
        //----------------------------------------------------------------------------------------------------------------------------------------
        body = GetComponent<Rigidbody>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        body.velocity = new Vector3(horizontal * 10, 0, vertical * 10);
    }
}
