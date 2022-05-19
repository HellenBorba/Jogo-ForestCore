using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public GameObject Glicose;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
       /* Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
        transform.position = Camera.main.ScreenToWorldPoint(mousePos);*/
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnMouseDown()
    {
        print("funfo");
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnMouseUp()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.y = Camera.main.nearClipPlane;
        transform.position = Camera.main.ScreenToWorldPoint(mousePos); 
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
