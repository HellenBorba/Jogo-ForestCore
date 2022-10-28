using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerCHO : MonoBehaviour
{
    public GameObject[] Objeto;
    public int vl, valor;
    public Button Oxigenio, Hidrogenio, Carbono;
    public Text perdeu;

    private ItemCollect IC;
    private GameContoller GC;
    private Núcleo NC;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        IC = GameObject.Find("Glicose").GetComponent<ItemCollect>();
        GC = GameObject.Find("GameController").GetComponent<GameContoller>();
        NC = GameObject.Find("Núcleo").GetComponent<Núcleo>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------------  
    public void Número(int val)
    {
        valor = val;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void Botões()
    {
        vl += 1;
        switch (vl)
        {
            #region H
            //----------------------------------------------------------------------------------------------------------------------------------------1-6-9-12-15-18
            case 1:
                if (valor == 2)
                {
                    Objeto[0].GetComponent<SpriteRenderer>().color = Color.green;
                }
                else
                if(valor == 1 || valor == 3)
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 6:
                if (valor == 2)
                {
                    Objeto[5].GetComponent<SpriteRenderer>().color = Color.green;
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 9:
                if (valor == 2)
                {
                    Objeto[8].GetComponent<SpriteRenderer>().color = Color.green;
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 12:
                if (valor == 2)
                {
                    Objeto[11].GetComponent<SpriteRenderer>().color = Color.green;
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 15:
                if (valor == 2)
                {
                    Objeto[14].GetComponent<SpriteRenderer>().color = Color.green;
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 18:
                if (valor == 2)
                {
                    Objeto[17].GetComponent<SpriteRenderer>().color = Color.green;
                    StartCoroutine(Final());
                    vl = 0;
                    valor = 0;
                    Erro();
                    GC.buton[2].SetActive(true);
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            #endregion
            #region O
            //----------------------------------------------------------------------------------------------------------------------------------------2-5-8-11-14-17
            case 2:
                if (valor == 1)
                {
                    Objeto[1].GetComponent<SpriteRenderer>().color = Color.green;
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 5:
                if (valor == 1)
                {
                    Objeto[4].GetComponent<SpriteRenderer>().color = Color.green;
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 8:
                if (valor == 1)
                {
                    Objeto[7].GetComponent<SpriteRenderer>().color = Color.green;
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 11:
                if (valor == 1)
                {
                    Objeto[10].GetComponent<SpriteRenderer>().color = Color.green;
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 14:
                if (valor == 1)
                {
                    Objeto[13].GetComponent<SpriteRenderer>().color = Color.green;
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 17:
                if (valor == 1)
                {
                    Objeto[16].GetComponent<SpriteRenderer>().color = Color.green;
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            #endregion
            #region C
            //----------------------------------------------------------------------------------------------------------------------------------------3-4-7-10-13-16
            case 3:
                if (valor == 3)
                {
                    Objeto[2].GetComponent<SpriteRenderer>().color = Color.green;
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 4:
                if (valor == 3)
                {
                    Objeto[3].GetComponent<SpriteRenderer>().color = Color.green;
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 7:
                if (valor == 3)
                {
                    Objeto[6].GetComponent<SpriteRenderer>().color = Color.green;
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 10:
                if (valor == 3)
                {
                    Objeto[9].GetComponent<SpriteRenderer>().color = Color.green;
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 13:
                if (valor == 3)
                {
                    Objeto[12].GetComponent<SpriteRenderer>().color = Color.green;
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 16:
                if (valor == 3)
                {
                    Objeto[15].GetComponent<SpriteRenderer>().color = Color.green;
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
                #endregion
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    IEnumerator OrdemErrada()
    {
        yield return new WaitForSeconds(0f);
        GC.panel[3].SetActive(true);
        yield return new WaitForSeconds(3f);
        GC.panel[3].SetActive(false);
    }
    IEnumerator Final()
    {
        yield return new WaitForSeconds(0f);
        GC.panel[4].SetActive(true);
        yield return new WaitForSeconds(2f);
        GC.panel[4].SetActive(false);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void Erro()
    {
        Objeto[0].GetComponent<SpriteRenderer>().color = Color.blue;
        Objeto[1].GetComponent<SpriteRenderer>().color = Color.red;
        Objeto[2].GetComponent<SpriteRenderer>().color = Color.white;
        Objeto[3].GetComponent<SpriteRenderer>().color = Color.white;
        Objeto[4].GetComponent<SpriteRenderer>().color = Color.red;
        Objeto[5].GetComponent<SpriteRenderer>().color = Color.blue;
        Objeto[6].GetComponent<SpriteRenderer>().color = Color.white;
        Objeto[7].GetComponent<SpriteRenderer>().color = Color.red;
        Objeto[8].GetComponent<SpriteRenderer>().color = Color.blue;
        Objeto[9].GetComponent<SpriteRenderer>().color = Color.white;
        Objeto[10].GetComponent<SpriteRenderer>().color = Color.red;
        Objeto[11].GetComponent<SpriteRenderer>().color = Color.blue;
        Objeto[12].GetComponent<SpriteRenderer>().color = Color.white;
        Objeto[13].GetComponent<SpriteRenderer>().color = Color.red;
        Objeto[14].GetComponent<SpriteRenderer>().color = Color.blue;
        Objeto[15].GetComponent<SpriteRenderer>().color = Color.white;
        Objeto[16].GetComponent<SpriteRenderer>().color = Color.red;
        Objeto[17].GetComponent<SpriteRenderer>().color = Color.blue;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
