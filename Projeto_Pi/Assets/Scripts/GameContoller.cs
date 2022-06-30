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
    public Slider slider;

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
        texto.text = "Progresso: " + contagem;
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
                    StartCoroutine(Case((int)Random.Range(0, 4)));
                }
                break;
            case 2:
                if(valor == 1)
                {
                    StartCoroutine(Case((int)Random.Range(0, 4)));
                    slider.value += 1;
                }
                break;
            case 4:
                if(valor == 3)
                {
                    StartCoroutine(Case((int)Random.Range(0, 4)));
                    slider.value += 1;
                }
                break;
            case 7:
                if(valor == 6)
                {
                    StartCoroutine(Case((int)Random.Range(0, 4)));
                    slider.value += 1;
                }
                break;
            case 11:
                if(valor == 10)
                {
                    slider.value += 1;
                    buton[5].SetActive(true);
                }
                break;
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    IEnumerator Case(int bla)
    {
        yield return new WaitForSeconds(0.5f);
        circulo[bla].interactable = false;
        yield return new WaitForSeconds(0.5f);
        circulo[bla].interactable = true;
        if(click >= 2)
        {
            StartCoroutine(Case1((int)Random.Range(0,4)));
        }
    }
    IEnumerator Case1(int bla)
    {
        yield return new WaitForSeconds(0.5f);
        circulo[bla].interactable = false;
        yield return new WaitForSeconds(0.5f);
        circulo[bla].interactable = true;
        if (click >= 4)
        {
            StartCoroutine(Case2((int)Random.Range(0, 4)));
        }
    }
    IEnumerator Case2(int bla)
    {
        yield return new WaitForSeconds(0.5f);
        circulo[bla].interactable = false;
        yield return new WaitForSeconds(0.5f);
        circulo[bla].interactable = true;
        if (click >= 7)
        {
            StartCoroutine(Case3((int)Random.Range(0, 4)));
        }
    }
    IEnumerator Case3(int bla)
    {
        yield return new WaitForSeconds(0.5f);
        circulo[bla].interactable = false;
        yield return new WaitForSeconds(0.5f);
        circulo[bla].interactable = true;
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
