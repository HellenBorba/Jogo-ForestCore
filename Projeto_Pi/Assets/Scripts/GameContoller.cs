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
    private int contagem, senha1, click, valor;
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
    public void Número(int val)
    {
        valor += val;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void Puzzle2()
    {
        click += 1;
        switch (click)
        {
            case 1:
                if (valor == 0)
                {
                    circulo[0].interactable = false;
                    StartCoroutine(Case1());
                }
                break;
            case 2:
                if(valor == 1)
                {
                    circulo[0].interactable = false;
                    StartCoroutine(Case2());
                }
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
    IEnumerator Case1()
    {
        yield return new WaitForSeconds(1f);
        circulo[0].interactable = true;
    }
    IEnumerator Case2()
    {
        yield return new WaitForSeconds(1f);
        circulo[0].interactable = false;
        yield return new WaitForSeconds(2f);
        circulo[0].interactable = true;
        yield return new WaitForSeconds(3f);
        circulo[1].interactable = false;
        yield return new WaitForSeconds(4f);
        circulo[1].interactable = true;
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
