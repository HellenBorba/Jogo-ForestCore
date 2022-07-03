using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameContoller : MonoBehaviour
{
    public GameObject[] buton, Camera;
    public Text texto_puzzle_2, texto_puzzle_1;
    public Button[] interact, circulo;
    public Button CirculoStart;
    public Slider slider;
    public int contagem;

    private int click, quantidade;
    private ItemCollect IC;
    private Núcleo NC;
    private string sequencia, valor, codigo;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        IC = GameObject.Find("Poço1").GetComponent<ItemCollect>();
        NC = GameObject.Find("Núcleo").GetComponent<Núcleo>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void Update()
    {
        #region Vitória
        if (contagem == 3)
        {
            StartCoroutine(Vitória());
        }
        #endregion
        //----------------------------------------------------------------------------------------------------------------------------------------
        #region Puzzle1
        if (quantidade == 4)
        {
            if (codigo != "3021")
            {
                StartCoroutine(Puzzle1Final());
                interact[0].interactable = true;
                interact[1].interactable = true;
                interact[2].interactable = true;
                interact[3].interactable = true;
                codigo = null;
                quantidade = 0;
            }
        }
        #endregion
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    #region Puzzle1
    public void seleciono(int numBotao)
    {
        codigo = codigo + numBotao;
        if (codigo == "3021")
        {
            buton[4].SetActive(true);
            NC.barraVida.value += 10;
        }
        //----------------------------------------------------------------------------------------------------------------------------------------
        switch (numBotao)
        {
            // 3 - 0 - 2 - 1 = 4 - 1 - 3 - 2
            case 0:
                quantidade += 1;
                interact[0].interactable = false;
                break;
            case 1:
                quantidade += 1;
                interact[1].interactable = false;
                break;
            case 2:
                quantidade += 1;
                interact[2].interactable = false;
                break;
            case 3:
                quantidade += 1;
                interact[3].interactable = false;
                break;
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    IEnumerator Puzzle1Final()
    {
        yield return new WaitForSeconds(0f);
        texto_puzzle_1.text = "Código incorreto!";
        yield return new WaitForSeconds(1.5f);
        texto_puzzle_1.text = "Reinicie!";
        yield return new WaitForSeconds(3f);
        texto_puzzle_1.text = "";
    }
    #endregion
    //----------------------------------------------------------------------------------------------------------------------------------------
    #region Puzzle2
    public void Número2(int val)
    {
        valor = valor + val;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void Puzzle2()
    {
        click += 1;
        switch (click)
        {
            case 1:
                StartCoroutine(Case((int)Random.Range(0, 4)));
                break;
            case 2:
                if(valor == sequencia)
                {
                    StartCoroutine(Case((int)Random.Range(0, 4)));
                    slider.value += 1;
                }else
                {
                    StartCoroutine(OrdemIncorreta());
                    click = 0;
                    sequencia = null;
                    valor = null;
                }
                break;
            case 4:
                if(valor == sequencia)
                {
                    StartCoroutine(Case((int)Random.Range(0, 4)));
                    slider.value += 1;
                }else
                {
                    StartCoroutine(OrdemIncorreta());
                    click = 0;
                    sequencia = null;
                    valor = null;
                }
                break;
            case 7:
                if(valor == sequencia)
                {
                    StartCoroutine(Case((int)Random.Range(0, 4)));
                    slider.value += 1;
                }else
                {
                    StartCoroutine(OrdemIncorreta());
                    click = 0;
                    sequencia = null;
                    valor = null;
                }
                break;
            case 11:
                if(valor == sequencia)
                {
                    slider.value += 1;
                    buton[5].SetActive(true);
                    NC.barraVida.value += 10;
                }
                else
                {
                    StartCoroutine(OrdemIncorreta());
                    click = 0;
                    sequencia = null;
                    valor = null;
                }
                break;
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    #region Corrotina Case
    IEnumerator Case(int bla)
    {
        yield return new WaitForSeconds(0.5f);
        circulo[bla].interactable = false;
        yield return new WaitForSeconds(0.5f);
        circulo[bla].interactable = true;
        sequencia = sequencia + bla;
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
        sequencia = sequencia + bla;
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
        sequencia = sequencia + bla;
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
        sequencia = sequencia + bla;
    }
    #endregion
    //----------------------------------------------------------------------------------------------------------------------------------------
    IEnumerator OrdemIncorreta()
    {
        yield return new WaitForSeconds(0f);
        texto_puzzle_2.text = "Ordem errada! click novamente em start para recomeçar!";
        yield return new WaitForSeconds(5f);
        texto_puzzle_2.text = null;
    }
    #endregion
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
    //----------------------------------------------------------------------------------------------------------------------------------------
    #region Vitória
    IEnumerator Vitória()
    {
        yield return new WaitForSeconds(0f);
        IC.panelV.SetActive(true);
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(0);
    }
    public void vitoria(int num)
    {
        contagem += num;
    }
    #endregion
}
