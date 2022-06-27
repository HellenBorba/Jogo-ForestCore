using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerCHO : MonoBehaviour
{
    public GameObject[] Objeto;
    public GameObject pontoFixoH, pontoFixoO, pontoFixoC;
    public Color green;
    public int vl, valor;
    public Button Oxigenio, Hidrogenio, Carbono;

    private ItemCollect IC;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        IC = GameObject.Find("Poço1").GetComponent<ItemCollect>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
      
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
                        Color a = green;
                        Objeto[0].GetComponent<SpriteRenderer>().color = a;
                    }
                }
                else
                {
                    IC.panel3P.SetActive(true);
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
                        Color b = green;
                        Objeto[5].GetComponent<SpriteRenderer>().color = b;
                    }
                }
                else
                {
                    print("nop");
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
                        Color c = green;
                        Objeto[8].GetComponent<SpriteRenderer>().color = c;
                    }
                }
                else
                {
                    print("nop");
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
                        Color d = green;
                        Objeto[11].GetComponent<SpriteRenderer>().color = d;
                    }
                }
                else
                {
                    print("nop");
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
                        Color e = green;
                        Objeto[14].GetComponent<SpriteRenderer>().color = e;
                    }
                }
                else
                {
                    print("nop");
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
                        Color f = green;
                        Objeto[17].GetComponent<SpriteRenderer>().color = f;
                    }
                }
                else
                {
                    print("nop");
                }
                break;
            case 36:
                Hidrogenio.transform.position = pontoFixoH.transform.position;
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
                        Color a = green;
                        Objeto[1].GetComponent<SpriteRenderer>().color = a;
                    }
                }
                else
                {
                    print("nop");
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
                        Color b = green;
                        Objeto[4].GetComponent<SpriteRenderer>().color = b;
                    }
                }
                else
                {
                    print("nop");
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
                        Color c = green;
                        Objeto[7].GetComponent<SpriteRenderer>().color = c;
                    }
                }
                else
                {
                    print("nop");
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
                        Color d = green;
                        Objeto[10].GetComponent<SpriteRenderer>().color = d;
                    }
                }
                else
                {
                    print("nop");
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
                        Color e = green;
                        Objeto[13].GetComponent<SpriteRenderer>().color = e;
                    }
                }
                else
                {
                    print("nop");
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
                        Color f = green;
                        Objeto[16].GetComponent<SpriteRenderer>().color = f;
                    }
                }
                else
                {
                    print("nop");
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
                        Color a = green;
                        Objeto[2].GetComponent<SpriteRenderer>().color = a;
                    }
                }
                else
                {
                    print("nop");
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
                        Color b = green;
                        Objeto[3].GetComponent<SpriteRenderer>().color = b;
                    }
                }
                else
                {
                    print("nop");
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
                        Color c = green;
                        Objeto[6].GetComponent<SpriteRenderer>().color = c;
                    }
                }
                else
                {
                    print("nop");
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
                        Color d = green;
                        Objeto[9].GetComponent<SpriteRenderer>().color = d;
                    }
                }
                else
                {
                    print("nop");
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
                        Color e = green;
                        Objeto[12].GetComponent<SpriteRenderer>().color = e;
                    }
                }
                else
                {
                    print("nop");
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
                        Color f = green;
                        Objeto[15].GetComponent<SpriteRenderer>().color = f;
                    }
                }
                else
                {
                    print("nop");
                }
                break;
            case 32:
                Carbono.transform.position = pontoFixoC.transform.position;
                break;
                #endregion
        }
    }
}
