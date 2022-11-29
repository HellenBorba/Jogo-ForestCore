using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Construções : MonoBehaviour
{
    public int C_E, C_E2;

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
    private void Update()
    {
        switch (C_E2)
        {
            case 3: //Puzzle0 Núcleo
                if (PY.efs == 5)
                {
                    GC.PaneisTutoriais[2].SetActive(true);
                    GC.InformaçãoPontos.text = "Click G para dados da árvore";
                }
                break;
        }
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
                        PY.efs2 = 1;
                    break;
            }
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnTriggerExit(Collider other)
    {
        PY.efs = 6;
        GC.PaneisTutoriais[2].SetActive(false);
        IC.Player.SetActive(true);
        Cursor.visible = false;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
