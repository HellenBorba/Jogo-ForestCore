using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ItemCollect_Multiplayer : MonoBehaviourPunCallbacks
{
    public int Itemtipo;

    private GameContoller_Multiplayer GCM;
    private PhotonView view;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        view = gameObject.GetComponent<PhotonView>();
        //----------------------------------------------------------------------------------------------------------------------------------------
        GCM = GameObject.Find("GameController_Multiplayer").GetComponent<GameContoller_Multiplayer>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnTriggerStay(Collider collision)
    {
        if (view.IsMine)
        {
            if (collision.gameObject.CompareTag("Player1") || (collision.gameObject.CompareTag("Player2")))
            {
                switch (Itemtipo)
                {
                    case 0:
                        if (Input.GetKey(KeyCode.E))
                        {
                            Cursor.visible = true;
                            GCM.panel[0].SetActive(true);
                        }
                        break;
                    case 1:
                        if (Input.GetKey(KeyCode.E))
                        {
                            Cursor.visible = true;
                            GCM.panel[1].SetActive(true);
                        }
                        break;
                    case 2:
                        if (Input.GetKey(KeyCode.E))
                        {
                            Cursor.visible = true;
                            GCM.panel[2].SetActive(true);
                        }
                        break;
                }
            }
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
