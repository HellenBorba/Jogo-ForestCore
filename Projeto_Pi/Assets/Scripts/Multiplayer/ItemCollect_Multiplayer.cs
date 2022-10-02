using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect_Multiplayer : MonoBehaviour
{
    public GameObject[] panel;
    public int Itemtipo;

    private GameContoller_Multiplayer GCM;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GCM = GameObject.Find("GameController").GetComponent<GameContoller_Multiplayer>();
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
                        panel[0].SetActive(true);
                    }
                    break;
                case 1:
                    if (Input.GetKey(KeyCode.E))
                    {
                        GCM.Camera[3].SetActive(true);
                        GCM.Camera[0].SetActive(false);
                        GCM.Camera[1].SetActive(false);
                        Cursor.visible = true;
                        panel[1].SetActive(true);
                    }
                    break;
                case 2:
                    if (Input.GetKey(KeyCode.E))
                    {
                        GCM.Camera[3].SetActive(true);
                        GCM.Camera[0].SetActive(false);
                        GCM.Camera[1].SetActive(false);
                        Cursor.visible = true;
                        panel[2].SetActive(true);
                    }
                    break;
                case 3:
                    GCM.Camera[2].SetActive(true);
                    GCM.Camera[0].SetActive(false);
                    GCM.Camera[1].SetActive(false);
                    break;
            }
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnTriggerExit(Collider other)
    {
        GCM.Camera[0].SetActive(true);
        GCM.Camera[1].SetActive(false);
        GCM.Camera[2].SetActive(false);
        GCM.Camera[3].SetActive(false);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
