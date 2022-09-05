using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour
{
    public GameObject panel0, panel1, panel2, panel2P, panel2F, panelV;
    public int Itemtipo;

    private GameContoller GC;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GC = GameObject.Find("GameController").GetComponent<GameContoller>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            switch (Itemtipo)
            {
                case 0:
                    if (Input.GetKey(KeyCode.E))
                    {
                        Cursor.visible = true;
                        panel0.SetActive(true);
                    }
                    break;
                case 1:
                    if (Input.GetKey(KeyCode.E))
                    {
                        GC.Camera[3].SetActive(true);
                        GC.Camera[0].SetActive(false);
                        GC.Camera[1].SetActive(false);
                        Cursor.visible = true;
                        panel1.SetActive(true);
                    }
                    break;
                case 2:
                    if (Input.GetKey(KeyCode.E))
                    {
                        GC.Camera[3].SetActive(true);
                        GC.Camera[0].SetActive(false);
                        GC.Camera[1].SetActive(false);
                        Cursor.visible = true;
                        panel2.SetActive(true);
                    }
                    break;
                case 3:
                    GC.Camera[2].SetActive(true);
                    GC.Camera[0].SetActive(false);
                    GC.Camera[1].SetActive(false);
                    break;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        GC.Camera[0].SetActive(true);
        GC.Camera[1].SetActive(false);
        GC.Camera[2].SetActive(false);
        GC.Camera[3].SetActive(false);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
