using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour
{
    public GameObject panel1, panel2, panel3, panel3P, panel3F, panelV;

    private int Itemtipo;
    private GameContoller GC;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GC = GameObject.Find("GameController").GetComponent<GameContoller>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            switch (Itemtipo)
            {
                case 0:
                    Cursor.visible = true;
                    panel1.SetActive(true);
                    break;
                case 1:
                    GC.Camera[2].SetActive(true);
                    GC.Camera[0].SetActive(false);
                    Cursor.visible = true;
                    panel2.SetActive(true);
                    break;
                case 2:
                    GC.Camera[1].SetActive(true);
                    GC.Camera[0].SetActive(false);
                    Cursor.visible = true;
                    panel3.SetActive(true);
                    break;
            }
        }
    }
}
