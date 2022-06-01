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
    private int contagem, cas, dig;
    private ItemCollect IC;
    bool ordem;
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
        //----------------------------------------------------------------------------------------------------------------------------------------
        if(cas == 4)
        {
            buton[4].SetActive(true);
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void seleciono(int numBotao)
    {
        print(numBotao);
        switch (numBotao)
        {
            // 1 - 3 - 2 - 0
            case 0:
                dig += 1;
                cas ++;
                interact[0].interactable = false;
                break;
            case 1:
                ordem = true;
                dig += 2;
                cas++;
                interact[1].interactable = false;
                break;
            case 2:
                dig += 3;
                cas++;
                interact[2].interactable = false;
                break;
            case 3:
                if (ordem)
                {
                    dig += 4;
                    cas++;
                    interact[3].interactable = false;
                }
                else
                {
                    ordem = false;
                }
              
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
        Camera[0].SetActive(true);
        Camera[1].SetActive(false);
        Camera[2].SetActive(false);
    }
}
