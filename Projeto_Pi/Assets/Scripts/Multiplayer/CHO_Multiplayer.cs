using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CHO_Multiplayer : MonoBehaviour
{
    public GameObject[] Objeto;
    public GameObject pontoFixoH, pontoFixoO, pontoFixoC, explicação;
    public int vl, valor;
    public Button Oxigenio, Hidrogenio, Carbono;
    public Text perdeu, tempo;

    public float timer;
    private GameContoller_Multiplayer GCM;
    private Núcleo_Multiplayer NCM;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GCM = GameObject.Find("GameController_Multiplayer").GetComponent<GameContoller_Multiplayer>();
        //----------------------------------------------------------------------------------------------------------------------------------------
        timer = 40;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        tempo.text = "Tempo restante: " + timer;
        //----------------------------------------------------------------------------------------------------------------------------------------
        if (vl >= 1)
        {
            timer -= Time.deltaTime;
            explicação.SetActive(false);
        }
        //----------------------------------------------------------------------------------------------------------------------------------------
        if (timer <= 0)
        {
            Erro();
            StartCoroutine(OrdemErrada());
            perdeu.text = "Seu tempo acabou!";
            vl = 0;
            timer = 40;
        }
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
            //----------------------------------------------------------------------------------------------------------------------------------------0-5-8-11-14-17
            case 1:
                if (valor == 2)
                {
                    Hidrogenio.transform.position = Objeto[0].transform.position;
                    if (Hidrogenio.transform.position == Objeto[0].transform.position)
                    {
                        Objeto[0].GetComponent<SpriteRenderer>().color = Color.green;
                    }
                }
                else
                if(valor == 1 || valor == 3)
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 2:
                Hidrogenio.transform.position = pontoFixoH.transform.position;
                break;
            case 11:
                if (valor == 2)
                {
                    Hidrogenio.transform.position = Objeto[5].transform.position;
                    if (Hidrogenio.transform.position == Objeto[5].transform.position)
                    {
                        Objeto[5].GetComponent<SpriteRenderer>().color = Color.green;
                    }
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 12:
                Hidrogenio.transform.position = pontoFixoH.transform.position;
                break;
            case 17:
                if (valor == 2)
                {
                    Hidrogenio.transform.position = Objeto[8].transform.position;
                    if (Hidrogenio.transform.position == Objeto[8].transform.position)
                    {
                        Objeto[8].GetComponent<SpriteRenderer>().color = Color.green;
                    }
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 18:
                Hidrogenio.transform.position = pontoFixoH.transform.position;
                break;
            case 23:
                if (valor == 2)
                {
                    Hidrogenio.transform.position = Objeto[11].transform.position;
                    if (Hidrogenio.transform.position == Objeto[11].transform.position)
                    {
                        Objeto[11].GetComponent<SpriteRenderer>().color = Color.green;
                    }
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 24:
                Hidrogenio.transform.position = pontoFixoH.transform.position;
                break;
            case 29:
                if (valor == 2)
                {
                    Hidrogenio.transform.position = Objeto[14].transform.position;
                    if (Hidrogenio.transform.position == Objeto[14].transform.position)
                    {
                        Objeto[14].GetComponent<SpriteRenderer>().color = Color.green;
                    }
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 30:
                Hidrogenio.transform.position = pontoFixoH.transform.position;
                break;
            case 35:
                if (valor == 2)
                {
                    Hidrogenio.transform.position = Objeto[17].transform.position;
                    if (Hidrogenio.transform.position == Objeto[17].transform.position)
                    {
                        Objeto[17].GetComponent<SpriteRenderer>().color = Color.green;
                        Hidrogenio.transform.position = pontoFixoH.transform.position;
                        StartCoroutine(Final());
                        GCM.buton[2].SetActive(true);
                        GCM.puzzles[4].SetActive(false);
                        GCM.puzzles[5].SetActive(true);
                    }
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
            //----------------------------------------------------------------------------------------------------------------------------------------1-4-7-10-13-16
            case 3:
                if (valor == 1)
                {
                    Oxigenio.transform.position = Objeto[1].transform.position;
                    if (Oxigenio.transform.position == Objeto[1].transform.position)
                    {
                        Objeto[1].GetComponent<SpriteRenderer>().color = Color.green;
                    }
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 4:
                Oxigenio.transform.position = pontoFixoO.transform.position;
                break;
            case 9:
                if (valor == 1)
                {
                    Oxigenio.transform.position = Objeto[4].transform.position;
                    if (Oxigenio.transform.position == Objeto[4].transform.position)
                    {
                        Objeto[4].GetComponent<SpriteRenderer>().color = Color.green;
                    }
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 10:
                Oxigenio.transform.position = pontoFixoO.transform.position;
                break;
            case 15:
                if (valor == 1)
                {
                    Oxigenio.transform.position = Objeto[7].transform.position;
                    if (Oxigenio.transform.position == Objeto[7].transform.position)
                    {
                        Objeto[7].GetComponent<SpriteRenderer>().color = Color.green;
                    }
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 16:
                Oxigenio.transform.position = pontoFixoO.transform.position;
                break;
            case 21:
                if (valor == 1)
                {
                    Oxigenio.transform.position = Objeto[10].transform.position;
                    if (Oxigenio.transform.position == Objeto[10].transform.position)
                    {
                        Objeto[10].GetComponent<SpriteRenderer>().color = Color.green;
                    }
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 22:
                Oxigenio.transform.position = pontoFixoO.transform.position;
                break;
            case 27:
                if (valor == 1)
                {
                    Oxigenio.transform.position = Objeto[13].transform.position;
                    if (Oxigenio.transform.position == Objeto[13].transform.position)
                    {
                        Objeto[13].GetComponent<SpriteRenderer>().color = Color.green;
                    }
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 28:
                Oxigenio.transform.position = pontoFixoO.transform.position;
                break;
            case 33:
                if (valor == 1)
                {
                    Oxigenio.transform.position = Objeto[16].transform.position;
                    if (Oxigenio.transform.position == Objeto[16].transform.position)
                    {
                        Objeto[16].GetComponent<SpriteRenderer>().color = Color.green;
                    }
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 34:
                Oxigenio.transform.position = pontoFixoO.transform.position;
                break;
            #endregion
            #region C
            //----------------------------------------------------------------------------------------------------------------------------------------2-3-6-9-12-15
            case 5:
                if (valor == 3)
                {
                    Carbono.transform.position = Objeto[2].transform.position;
                    if (Carbono.transform.position == Objeto[2].transform.position)
                    {
                        Objeto[2].GetComponent<SpriteRenderer>().color = Color.green;
                    }
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 6:
                Carbono.transform.position = pontoFixoC.transform.position;
                break;
            case 7:
                if (valor == 3)
                {
                    Carbono.transform.position = Objeto[3].transform.position;
                    if (Carbono.transform.position == Objeto[3].transform.position)
                    {
                        Objeto[3].GetComponent<SpriteRenderer>().color = Color.green;
                    }
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 8:
                Carbono.transform.position = pontoFixoC.transform.position;
                break;
            case 13:
                if (valor == 3)
                {
                    Carbono.transform.position = Objeto[6].transform.position;
                    if (Carbono.transform.position == Objeto[6].transform.position)
                    {
                        Objeto[6].GetComponent<SpriteRenderer>().color = Color.green;
                    }
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 14:
                Carbono.transform.position = pontoFixoC.transform.position;
                break;
            case 19:
                if (valor == 3)
                {
                    Carbono.transform.position = Objeto[9].transform.position;
                    if (Carbono.transform.position == Objeto[9].transform.position)
                    {
                        Objeto[9].GetComponent<SpriteRenderer>().color = Color.green;
                    }
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 20:
                Carbono.transform.position = pontoFixoC.transform.position;
                break;
            case 25:
                if (valor == 3)
                {
                    Carbono.transform.position = Objeto[12].transform.position;
                    if (Carbono.transform.position == Objeto[12].transform.position)
                    {
                        Objeto[12].GetComponent<SpriteRenderer>().color = Color.green;
                    }
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 26:
                Carbono.transform.position = pontoFixoC.transform.position;
                break;
            case 31:
                if (valor == 3)
                {
                    Carbono.transform.position = Objeto[15].transform.position;
                    if (Carbono.transform.position == Objeto[15].transform.position)
                    {
                        Objeto[15].GetComponent<SpriteRenderer>().color = Color.green;
                    }
                }
                else
                {
                    StartCoroutine(OrdemErrada());
                    Erro();
                    vl = 0;
                }
                break;
            case 32:
                Carbono.transform.position = pontoFixoC.transform.position;
                break;
                #endregion
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    IEnumerator OrdemErrada()
    {
        yield return new WaitForSeconds(0f);
        GCM.panel[3].SetActive(true);
        yield return new WaitForSeconds(3f);
        GCM.panel[3].SetActive(false);
    }
    IEnumerator Final()
    {
        yield return new WaitForSeconds(0f);
        GCM.panel[4].SetActive(true);
        yield return new WaitForSeconds(2f);
        GCM.panel[4].SetActive(false);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void Erro()
    {
        Objeto[0].GetComponent<SpriteRenderer>().color = Color.blue;
        Objeto[1].GetComponent<SpriteRenderer>().color = Color.red;
        Objeto[2].GetComponent<SpriteRenderer>().color = Color.black;
        Objeto[3].GetComponent<SpriteRenderer>().color = Color.black;
        Objeto[4].GetComponent<SpriteRenderer>().color = Color.red;
        Objeto[5].GetComponent<SpriteRenderer>().color = Color.blue;
        Objeto[6].GetComponent<SpriteRenderer>().color = Color.black;
        Objeto[7].GetComponent<SpriteRenderer>().color = Color.red;
        Objeto[8].GetComponent<SpriteRenderer>().color = Color.blue;
        Objeto[9].GetComponent<SpriteRenderer>().color = Color.black;
        Objeto[10].GetComponent<SpriteRenderer>().color = Color.red;
        Objeto[11].GetComponent<SpriteRenderer>().color = Color.blue;
        Objeto[12].GetComponent<SpriteRenderer>().color = Color.black;
        Objeto[13].GetComponent<SpriteRenderer>().color = Color.red;
        Objeto[14].GetComponent<SpriteRenderer>().color = Color.blue;
        Objeto[15].GetComponent<SpriteRenderer>().color = Color.black;
        Objeto[16].GetComponent<SpriteRenderer>().color = Color.red;
        Objeto[17].GetComponent<SpriteRenderer>().color = Color.blue;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
