using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollect : MonoBehaviour
{
    public GameObject[] panel;
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
                        panel[0].SetActive(true);
                        StartCoroutine(Tutorial0());
                    }
                    break;
                case 1:
                    if (Input.GetKey(KeyCode.E))
                    {
                        GC.Camera[3].SetActive(true);
                        GC.Camera[0].SetActive(false);
                        GC.Camera[1].SetActive(false);
                        Cursor.visible = true;
                        panel[1].SetActive(true);
                        StartCoroutine(Tutorial1());
                    }
                    break;
                case 2:
                    if (Input.GetKey(KeyCode.E))
                    {
                        GC.Camera[3].SetActive(true);
                        GC.Camera[0].SetActive(false);
                        GC.Camera[1].SetActive(false);
                        Cursor.visible = true;
                        panel[2].SetActive(true);
                        StartCoroutine(Tutorial2());
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
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnTriggerExit(Collider other)
    {
        GC.Camera[0].SetActive(true);
        GC.Camera[1].SetActive(false);
        GC.Camera[2].SetActive(false);
        GC.Camera[3].SetActive(false);
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
