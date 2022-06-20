using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerCHO : MonoBehaviour
{
    public GameObject[] Objeto;
    public GameObject pontoFixoH, pontoFixoO, pontoFixoC, Oxigenio, Hidrogenio, Carbono;
    public Color green;

    [SerializeField]
    private string ordem;
    private GameContoller GC;
    private ItemCollect IC;
    [SerializeField]
    private int vl;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GC = GameObject.Find("GameController").GetComponent<GameContoller>();
        IC = GameObject.Find("Poço").GetComponent<ItemCollect>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        //perguntar desde sempre, vermelho-1 azul-2 preto-3
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    #region H
    public void BotãoH()
    {
        ordem = ordem + vl;
        //----------------------------------------------------------------------------------------------------------------------------------------0-5-8-11-14-17
        vl += 1;
        switch (vl)
        {
            case 1:
                Hidrogenio.transform.position = Objeto[0].transform.position;
                if (Hidrogenio.transform.position == Objeto[0].transform.position)
                {
                    Color a = green;
                    Objeto[0].GetComponent<SpriteRenderer>().color = a;
                }
                break;
            case 2:
                Hidrogenio.transform.position = pontoFixoH.transform.position;
                break;
            case 11:
                Hidrogenio.transform.position = Objeto[5].transform.position;
                if(Hidrogenio.transform.position == Objeto[5].transform.position)
                {
                    Color b = green;
                    Objeto[5].GetComponent<SpriteRenderer>().color = b;
                }
                break;
            case 12:
                Hidrogenio.transform.position = pontoFixoH.transform.position;
                break;
            case 17:
                Hidrogenio.transform.position = Objeto[8].transform.position;
                if(Hidrogenio.transform.position == Objeto[8].transform.position)
                {
                    Color c = green;
                    Objeto[8].GetComponent<SpriteRenderer>().color = c;
                }
                break;
            case 18:
                Hidrogenio.transform.position = pontoFixoH.transform.position;
                break;
            case 23:
                Hidrogenio.transform.position = Objeto[11].transform.position;
                if(Hidrogenio.transform.position == Objeto[11].transform.position)
                {
                    Color d = green;
                    Objeto[11].GetComponent<SpriteRenderer>().color = d;
                }
                break;
            case 24:
                Hidrogenio.transform.position = pontoFixoH.transform.position;
                break;
            case 29:
                Hidrogenio.transform.position = Objeto[14].transform.position;
                if (Hidrogenio.transform.position == Objeto[14].transform.position)
                {
                    Color e = green;
                    Objeto[14].GetComponent<SpriteRenderer>().color = e;
                }
                break;
            case 30:
                Hidrogenio.transform.position = pontoFixoH.transform.position;
                break;
            case 35:
                Hidrogenio.transform.position = Objeto[17].transform.position;
                if (Hidrogenio.transform.position == Objeto[17].transform.position)
                {
                    Color f = green;
                    Objeto[17].GetComponent<SpriteRenderer>().color = f;
                }
                break;
            case 36:
                Hidrogenio.transform.position = pontoFixoH.transform.position;
                break;
        }
    }
    #endregion
    //----------------------------------------------------------------------------------------------------------------------------------------
    #region O
    public void BotãoO()
    {
        ordem = ordem + vl;
        //----------------------------------------------------------------------------------------------------------------------------------------1-4-7-10-13-16
        vl += 1;
        switch (vl)
        {
            case 3:
                Oxigenio.transform.position = Objeto[1].transform.position;
                if (Oxigenio.transform.position == Objeto[1].transform.position)
                {
                    Color a = green;
                    Objeto[1].GetComponent<SpriteRenderer>().color = a;
                }
                break;
            case 4:
                Oxigenio.transform.position = pontoFixoO.transform.position;
                break;
            case 9:
                Oxigenio.transform.position = Objeto[4].transform.position;
                if (Oxigenio.transform.position == Objeto[4].transform.position)
                {
                    Color b = green;
                    Objeto[4].GetComponent<SpriteRenderer>().color = b;
                }
                break;
            case 10:
                Oxigenio.transform.position = pontoFixoO.transform.position;
                break;
            case 15:
                Oxigenio.transform.position = Objeto[7].transform.position;
                if (Oxigenio.transform.position == Objeto[7].transform.position)
                {
                    Color c = green;
                    Objeto[7].GetComponent<SpriteRenderer>().color = c;
                }
                break;
            case 16:
                Oxigenio.transform.position = pontoFixoO.transform.position;
                break;
            case 21:
                Oxigenio.transform.position = Objeto[10].transform.position;
                if (Oxigenio.transform.position == Objeto[10].transform.position)
                {
                    Color d = green;
                    Objeto[10].GetComponent<SpriteRenderer>().color = d;
                }
                break;
            case 22:
                Oxigenio.transform.position = pontoFixoO.transform.position;
                break;
            case 27:
                Oxigenio.transform.position = Objeto[13].transform.position;
                if (Oxigenio.transform.position == Objeto[13].transform.position)
                {
                    Color e = green;
                    Objeto[13].GetComponent<SpriteRenderer>().color = e;
                }
                break;
            case 28:
                Oxigenio.transform.position = pontoFixoO.transform.position;
                break;
            case 33:
                Oxigenio.transform.position = Objeto[16].transform.position;
                if (Oxigenio.transform.position == Objeto[16].transform.position)
                {
                    Color f = green;
                    Objeto[16].GetComponent<SpriteRenderer>().color = f;
                }
                break;
            case 34:
                Oxigenio.transform.position = pontoFixoO.transform.position;
                break;
        }
    }
    #endregion
    //----------------------------------------------------------------------------------------------------------------------------------------
    #region C
    public void BotãoC()
    {
        ordem = ordem + vl;
        //----------------------------------------------------------------------------------------------------------------------------------------2-3-6-9-12-15
        vl += 1;
        switch (vl)
        {
            case 5:
                Carbono.transform.position = Objeto[2].transform.position;
                if (Carbono.transform.position == Objeto[2].transform.position)
                {
                    Color a = green;
                    Objeto[2].GetComponent<SpriteRenderer>().color = a;
                }
                break;
            case 6:
                Carbono.transform.position = pontoFixoC.transform.position;
                break;
            case 7:
                Carbono.transform.position = Objeto[3].transform.position;
                if (Carbono.transform.position == Objeto[3].transform.position)
                {
                    Color b = green;
                    Objeto[3].GetComponent<SpriteRenderer>().color = b;
                }
                break;
            case 8:
                Carbono.transform.position = pontoFixoC.transform.position;
                break;
            case 13:
                Carbono.transform.position = Objeto[6].transform.position;
                if (Carbono.transform.position == Objeto[6].transform.position)
                {
                    Color c = green;
                    Objeto[6].GetComponent<SpriteRenderer>().color = c;
                }
                break;
            case 14:
                Carbono.transform.position = pontoFixoC.transform.position;
                break;
            case 19:
                Carbono.transform.position = Objeto[9].transform.position;
                if (Carbono.transform.position == Objeto[9].transform.position)
                {
                    Color d = green;
                    Objeto[9].GetComponent<SpriteRenderer>().color = d;
                }
                break;
            case 20:
                Carbono.transform.position = pontoFixoC.transform.position;
                break;
            case 25:
                Carbono.transform.position = Objeto[12].transform.position;
                if (Carbono.transform.position == Objeto[12].transform.position)
                {
                    Color e = green;
                    Objeto[12].GetComponent<SpriteRenderer>().color = e;
                }
                break;
            case 26:
                Carbono.transform.position = pontoFixoC.transform.position;
                break;
            case 31:
                Carbono.transform.position = Objeto[15].transform.position;
                if (Carbono.transform.position == Objeto[15].transform.position)
                {
                    Color f = green;
                    Objeto[15].GetComponent<SpriteRenderer>().color = f;
                }
                break;
            case 32:
                Carbono.transform.position = pontoFixoC.transform.position;
                break;
        }
    }
    #endregion
}
