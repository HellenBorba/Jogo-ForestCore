using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameContoller : MonoBehaviour
{
    public GameObject[] buton;
    public Text texto;
    public GameObject Camera1, Camera2, Camera3;

    private int Contagem;
    private ItemCollect IC;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        IC = GameObject.Find("Poço").GetComponent<ItemCollect>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        if (IC.scrollbar.value >= 1) 
        {
            IC.scrollbar.value = 0;
            Contagem++;
        }
        //----------------------------------------------------------------------------------------------------------------------------------------
        texto.text = "Progresso: " + Contagem + " = 200";
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void seleciono(int ButtonTipo)
    {
        switch (ButtonTipo)
        {
            case 0:
                var colors = buton[0].GetComponent<Button>().colors;
                colors.normalColor = Color.green;
                buton[0].GetComponent<Button>().colors = colors;
                break;
            case 1:
                var colors1 = buton[1].GetComponent<Button>().colors;
                colors1.normalColor = Color.green;
                buton[1].GetComponent<Button>().colors = colors1;
                break;
            case 2:
                var colors2 = buton[2].GetComponent<Button>().colors;
                colors2.normalColor = Color.green;
                buton[2].GetComponent<Button>().colors = colors2;
                break;
            case 3:
                var colors3 = buton[3].GetComponent<Button>().colors;
                colors3.normalColor = Color.green;
                buton[3].GetComponent<Button>().colors = colors3;
                buton[4].SetActive(true);
                break;
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void End()
    {
        if (Contagem >= 200)
        {
            buton[5].SetActive(true);
        }
    }
    //---------------------------------------------------------------------------------------------------------------------------------------- 
    public void Panel()
    {
        IC.panel.SetActive(false);
        Camera1.SetActive(true);
        Camera2.SetActive(false);
    }
}
