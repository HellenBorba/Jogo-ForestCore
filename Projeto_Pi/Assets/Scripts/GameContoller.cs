using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameContoller : MonoBehaviour
{
    public GameObject[] buton;
    public Text texto;
    public GameObject[] Camera;
    public Button[] interact;

    [SerializeField]
    private int contagem;
    private ItemCollect IC;
    private string senha;
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
            contagem++;
        }
        //----------------------------------------------------------------------------------------------------------------------------------------
        texto.text = "Progresso: " + contagem + " = 200";
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void seleciono(int numBotao)
    {
        senha = senha + numBotao;
        if(senha == "3021")
        {
            buton[4].SetActive(true);
        }
        //----------------------------------------------------------------------------------------------------------------------------------------
        switch (numBotao)
        {
            // 3 - 0 - 2 - 1 = 4 - 1 - 3 - 2
            case 0:
                interact[0].interactable = false;
                break;
            case 1:
                interact[1].interactable = false;
                break;
            case 2:
                interact[2].interactable = false;
                break;
            case 3:
                interact[3].interactable = false;
                break;
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void Puzzle_2()
    {
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
