using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollect : MonoBehaviour
{
    public int Itemtipo, Lugar;
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
        Cursor.visible = false;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    #region Item Tipo
    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            TextoDoJog.SetActive(true);
            switch (Itemtipo)
            {
                case 0:
                    if (Input.GetKey(KeyCode.E))
                    {
                        TextoDoJog.SetActive(false);
                        GC.Camera[1].SetActive(true);
                        GC.Camera[0].SetActive(false);
                        GC.Camera[2].SetActive(false);
                        Cursor.visible = true;
                        StartCoroutine(Puzzle0());
                        Player.SetActive(false);
                        GC.PaneisTutoriais[2].SetActive(false);
                    }
                    break;
                case 1:
                    if (Input.GetKey(KeyCode.E))
                    {
                        TextoDoJog.SetActive(false);
                        GC.Camera[1].SetActive(true);
                        GC.Camera[0].SetActive(false);
                        GC.Camera[2].SetActive(false);
                        Cursor.visible = true;
                        StartCoroutine(Puzzle1());
                        StartCoroutine(Tutorial1());
                        Player.SetActive(false);
                        GC.PaneisTutoriais[2].SetActive(false);
                    }
                    break;
                case 2:
                    if (Input.GetKey(KeyCode.E))
                    {
                        TextoDoJog.SetActive(false);
                        GC.Camera[1].SetActive(true);
                        GC.Camera[0].SetActive(false);
                        GC.Camera[2].SetActive(false);
                        Cursor.visible = true;
                        StartCoroutine(Puzzle2());
                        StartCoroutine(Tutorial2());
                        Player.SetActive(false);
                        GC.PaneisTutoriais[2].SetActive(false);
                        GC.buton[3].SetActive(false);
                    }
                    break;
            }
        }
    }
    #endregion
    //----------------------------------------------------------------------------------------------------------------------------------------
    #region Tutoriais
    IEnumerator Tutorial1()
    {
        yield return new WaitForSeconds(1f);
        GC.PaneisTutoriais[0].SetActive(true);
    }
    IEnumerator Tutorial2()
    {
        yield return new WaitForSeconds(1f);
        GC.PaneisTutoriais[1].SetActive(true);
    }
    #endregion
    #region PuzzlesPaineis
    IEnumerator Puzzle0()
    {
        yield return new WaitForSeconds(1.5f);
        GC.panel[0].SetActive(true);
    }
    IEnumerator Puzzle1()
    {
        yield return new WaitForSeconds(1.5f);
        GC.panel[1].SetActive(true);
    }
    IEnumerator Puzzle2()
    {
        yield return new WaitForSeconds(1.5f);
        GC.panel[2].SetActive(true);
    }
    #endregion
}
