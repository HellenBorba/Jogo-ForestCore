using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Construções : MonoBehaviour
{
    public int C_E;

    private Player PY;
    private ItemCollect IC;
    private GameContoller GC;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        PY = GameObject.Find("Player_Game").GetComponent<Player>();
        IC = GameObject.Find("poço").GetComponent<ItemCollect>();
        GC = GameObject.Find("GameController").GetComponent<GameContoller>();
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
                case 3: //Puzzle0
                    GC.PaneisTutoriais[2].SetActive(true);
                    GC.InformaçãoPontos.text = "Click G para dados da árvore";
                    break;
            }
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnTriggerExit(Collider other)
    {
        PY.efs = 4;
        GC.PaneisTutoriais[2].SetActive(false);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
