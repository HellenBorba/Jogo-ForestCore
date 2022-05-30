using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public Rigidbody rig;
    public GameObject hidri;
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
        gameObject.transform.position = hidri.transform.position;
        /*
        print("drag");
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = new Vector2(mousePos.x, mousePos.y)s;
        print("oi");
        */
        //rig.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, - Camera.main.transform.position.z));
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
