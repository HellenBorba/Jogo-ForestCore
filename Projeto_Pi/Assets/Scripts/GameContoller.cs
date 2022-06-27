using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameContoller : MonoBehaviour
{
    public GameObject[] buton, Camera;
    public Text texto;
    public Button[] interact, circulo;
    public Button CirculoStart;

    [SerializeField]
    private int contagem, senha1;
    private ItemCollect IC;
    [SerializeField]
    private string senha;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        IC = GameObject.Find("Poço1").GetComponent<ItemCollect>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        if (IC.scrollbar.value == 1) 
        {
            contagem++;
            IC.scrollbar.value = 0;
        }
        //----------------------------------------------------------------------------------------------------------------------------------------
        texto.text = "Progresso: " + contagem + " = 200";
        //----------------------------------------------------------------------------------------------------------------------------------------
        if (senha1 == 4)
        {
            if (senha != "3021")
            {
                Panel();
            }
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void seleciono(int numBotao)
    {
        senha = senha + numBotao;
        if (senha == "3021")
        {
            buton[4].SetActive(true);
        }
        //----------------------------------------------------------------------------------------------------------------------------------------
        switch (numBotao)
        {
            // 3 - 0 - 2 - 1 = 4 - 1 - 3 - 2
            case 0:
                senha1 += 1;
                interact[0].interactable = false;
                break;
            case 1:
                senha1 += 1;
                interact[1].interactable = false;
                break;
            case 2:
                senha1 += 1;
                interact[2].interactable = false;
                break;
            case 3:
                senha1 += 1;
                interact[3].interactable = false;
                break;
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void Puzzle2(int click)
    {
        switch(click)
        {
            case 1:
                break;
            case 2:
                circulo[0].GetComponent<SpriteRenderer>().color = Color.green;
                break;
            case 3:
                break;
        }
        //----------------------------------------------------------------------------------------------------------------------------------------
        if (contagem >= 200)
        {
            buton[5].SetActive(true);
        }
    }
    //---------------------------------------------------------------------------------------------------------------------------------------- 
    public void Panel()
    {
        IC.panel1.SetActive(false);
        IC.panel2.SetActive(false);
        IC.panel3.SetActive(false);
        Camera[0].SetActive(true);
        Camera[1].SetActive(false);
        Camera[2].SetActive(false);
    } 
}
