using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Construções : MonoBehaviour
{
    public int C_E;

    private Player PY;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        PY = GameObject.Find("Player_Game").GetComponent<Player>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            switch (C_E)
            {
                case 1: //Puzzle0
                    PY.efs = 5;
                    break;
                case 2: //Puzzle2
                    PY.efs = 3;
                    break;
            }
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnTriggerExit(Collider other)
    {
        PY.efs = 4;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
