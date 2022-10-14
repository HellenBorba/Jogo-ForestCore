using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollect : MonoBehaviour
{
    public GameObject[] panel;
    public int Itemtipo;
    public Text TextoDoJogo;
    public GameObject TextoDoJog;
    public GameObject Player;

    private GameContoller GC;
    private Player PL;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GC = GameObject.Find("GameController").GetComponent<GameContoller>();
        PL = GameObject.Find("Player_Game").GetComponent<Player>();
        //----------------------------------------------------------------------------------------------------------------------------------------
        Cursor.visible = true;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    #region Item Tipo
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            TextoDoJogo.text = "Click E";
            switch (Itemtipo)
            {
                case 0:
                    if (Input.GetKey(KeyCode.E))
                    {
                        TextoDoJogo.text = "";
                        GC.Camera[3].SetActive(true);
                        GC.Camera[0].SetActive(false);
                        GC.Camera[1].SetActive(false);
                        Cursor.visible = true;
                        panel[0].SetActive(true);
                        StartCoroutine(Tutorial0());
                        Player.SetActive(false);
                    }
                    break;
                case 1:
                    if (Input.GetKey(KeyCode.E))
                    {
                        TextoDoJogo.text = "";
                        GC.Camera[3].SetActive(true);
                        GC.Camera[0].SetActive(false);
                        GC.Camera[1].SetActive(false);
                        Cursor.visible = true;
                        panel[1].SetActive(true);
                        StartCoroutine(Tutorial1());
                        Player.SetActive(false);
                    }
                    break;
                case 2:
                    if (Input.GetKey(KeyCode.E))
                    {
                        TextoDoJogo.text = "";
                        GC.Camera[3].SetActive(true);
                        GC.Camera[0].SetActive(false);
                        GC.Camera[1].SetActive(false);
                        Cursor.visible = true;
                        panel[2].SetActive(true);
                        StartCoroutine(Tutorial2());
                        Player.SetActive(false);
                    }
                    break;
                case 3:
                    PL.efs = 3;
                    break;
            }
        }
    }
    #endregion
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnTriggerExit(Collider other)
    {
        PL.efs = 4;
        TextoDoJogo.text = "";
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    #region Tutoriais
    IEnumerator Tutorial0()
    {
        yield return new WaitForSeconds(1f);
        GC.PaneisTutoriais[0].SetActive(true);
    }
    IEnumerator Tutorial1()
    {
        yield return new WaitForSeconds(1f);
        GC.PaneisTutoriais[1].SetActive(true);
    }
    IEnumerator Tutorial2()
    {
        yield return new WaitForSeconds(1f);
        GC.PaneisTutoriais[2].SetActive(true);
    }
    #endregion
}
