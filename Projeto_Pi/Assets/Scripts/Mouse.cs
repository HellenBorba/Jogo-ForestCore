using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public Rigidbody rigidbody;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
      
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnMouseDown()
    {
        print("click");
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnMouseDrag()
    {
        print("drag");
        /*
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = new Vector2(mousePos.x, mousePos.y);
        print("oi");
        */
        rigidbody.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnMouseUp()
    {
        print("up");
        /*
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        transform.position = Camera.main.ScreenToWorldPoint(mousePos);
        */
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mol"))
        {
            collision.gameObject.transform.position = transform.position;
        }
    }
   
}
