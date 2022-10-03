using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ItemCollect_Multiplayer : MonoBehaviour
{
    public GameObject[] panel;
    public int Itemtipo;

    private GameContoller_Multiplayer GCM;
    private PhotonView view;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        view = gameObject.GetComponent<PhotonView>();
        //----------------------------------------------------------------------------------------------------------------------------------------
        GCM = GameObject.Find("GameController").GetComponent<GameContoller_Multiplayer>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnTriggerStay(Collider collision)
    {
        if (view.IsMine)
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
                            Cursor.visible = true;
                            panel[1].SetActive(true);
                        }
                        break;
                    case 2:
                        if (Input.GetKey(KeyCode.E))
                        {
                            Cursor.visible = true;
                            panel[2].SetActive(true);
                        }
                        break;
                }
            }
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
