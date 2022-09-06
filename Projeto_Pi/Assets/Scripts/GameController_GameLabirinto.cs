using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController_GameLabirinto : MonoBehaviour
{
    public GameObject PlayerL;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {

    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("PlayerL"))
        {
            Destroy(PlayerL);
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
