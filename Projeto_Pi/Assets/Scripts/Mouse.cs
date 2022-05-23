using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
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
      
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnMouseUp()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane;
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
