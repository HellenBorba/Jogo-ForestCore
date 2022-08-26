using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameContoller : MonoBehaviour
{
    public GameObject[] buton, Camera, puzzles;
    public Button[] interact, circulo;
    public Text texto_puzzle_2, texto_puzzle_1, texto_puzzle2_1;
    public Button CirculoStart;
    public Slider slider;

    private int click, quantidade, contagem, numeroCirculos;
    private string sequencia, valor, codigo;
    private ItemCollect IC;
    private Núcleo NC;
    private Player PY;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        IC = GameObject.Find("Default_poço").GetComponent<ItemCollect>();
        NC = GameObject.Find("Núcleo").GetComponent<Núcleo>();
        PY = GameObject.Find("Player").GetComponent<Player>();
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
        #region Puzzle0
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
    #region Puzzle0
    public void Seleciono(int numBotao)
    {
        codigo = codigo + numBotao;
        if (codigo == "3021")
        {
            buton[0].SetActive(true);
            NC.barraVida.value += 10;
            puzzles[0].SetActive(false);
            puzzles[1].SetActive(true);
            PY.textoAvisoPuzzle2.SetActive(false);
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
    #region Puzzle1
    public void Número1(int val)
    {
        valor = valor + val;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void Puzzle1()
    {
        click += 1;
        switch (click)
        {
            case 1:
                StartCoroutine(Case((int)Random.Range(0, 4)));
                texto_puzzle_2.text = "Espere o círculo brilhar, e depois click no que brilhar!";
                texto_puzzle2_1.text = "1° onda";
                break;
            case 2:
                if(valor == sequencia)
                {
                    numeroCirculos = 0;
                    StartCoroutine(Case((int)Random.Range(0, 4)));
                    texto_puzzle_2.text = "Espere os 2 círculos brilharem, e depois click nos 2 que brilharem!";
                    texto_puzzle2_1.text = "2° onda";
                    slider.value += 1;
                }else
                {
                    StartCoroutine(OrdemIncorreta());
                    click = 0;
                    sequencia = null;
                    valor = null;
                    slider.value = 0;
                    numeroCirculos = 0;
                }
                break;
            case 4:
                if(valor == sequencia)
                {
                    numeroCirculos = 0;
                    StartCoroutine(Case((int)Random.Range(0, 4)));
                    texto_puzzle_2.text = "Espere os 3 círculos brilharem, e depois click nos 3 que brilharem!";
                    texto_puzzle2_1.text = "3° onda";
                    slider.value += 1;
                }else
                {
                    StartCoroutine(OrdemIncorreta());
                    click = 0;
                    sequencia = null;
                    valor = null;
                    slider.value = 0;
                    numeroCirculos = 0;
                }
                break;
            case 7:
                if(valor == sequencia)
                {
                    numeroCirculos = 0;
                    StartCoroutine(Case((int)Random.Range(0, 4)));
                    texto_puzzle_2.text = "Espere os 4 círculos brilharem, e depois click nos 4 que brilharem!";
                    texto_puzzle2_1.text = "4° onda";
                    slider.value += 1;
                }else
                {
                    StartCoroutine(OrdemIncorreta());
                    click = 0;
                    sequencia = null;
                    valor = null;
                    slider.value = 0;
                    numeroCirculos = 0;
                }
                break;
            case 11:
                if(valor == sequencia)
                {
                    texto_puzzle2_1.text = "Fim!";
                    texto_puzzle_2.text = "Parabéns!";
                    slider.value += 1;
                    buton[1].SetActive(true);
                    NC.barraVida.value += 10;
                    puzzles[2].SetActive(false);
                    puzzles[3].SetActive(true);
                }
                else
                {
                    StartCoroutine(OrdemIncorreta());
                    click = 0;
                    sequencia = null;
                    valor = null;
                    slider.value = 0;
                    numeroCirculos = 0;
                }
                break;
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    #region Corrotina Case
    IEnumerator Case(int bla)
    {
        yield return new WaitForSeconds(0.5f);
        circulo[0].interactable = false;
        circulo[1].interactable = false;
        circulo[2].interactable = false;
        circulo[3].interactable = false;
        yield return new WaitForSeconds(2f);
        numeroCirculos++;
        circulo[bla].interactable = true;
        texto_puzzle2_1.text = "Contagem de círculos que brilharam: " + numeroCirculos;
        yield return new WaitForSeconds(2f);
        circulo[0].interactable = true;
        circulo[1].interactable = true;
        circulo[2].interactable = true;
        circulo[3].interactable = true;
        sequencia = sequencia + bla;
        if(click >= 2)
        {
            StartCoroutine(Case1((int)Random.Range(0,4)));
        }
    }
    IEnumerator Case1(int bla)
    {
        yield return new WaitForSeconds(0.5f);
        circulo[0].interactable = false;
        circulo[1].interactable = false;
        circulo[2].interactable = false;
        circulo[3].interactable = false;
        yield return new WaitForSeconds(2f);
        numeroCirculos++;
        circulo[bla].interactable = true;
        texto_puzzle2_1.text = "Contagem de círculos que brilharam: " + numeroCirculos;
        yield return new WaitForSeconds(2f);
        circulo[0].interactable = true;
        circulo[1].interactable = true;
        circulo[2].interactable = true;
        circulo[3].interactable = true;
        sequencia = sequencia + bla;
        if (click >= 4)
        {
            StartCoroutine(Case2((int)Random.Range(0, 4)));
        }
    }
    IEnumerator Case2(int bla)
    {
        yield return new WaitForSeconds(0.5f);
        circulo[0].interactable = false;
        circulo[1].interactable = false;
        circulo[2].interactable = false;
        circulo[3].interactable = false;
        yield return new WaitForSeconds(2f);
        numeroCirculos++;
        circulo[bla].interactable = true;
        texto_puzzle2_1.text = "Contagem de círculos que brilharam: " + numeroCirculos;
        yield return new WaitForSeconds(2f);
        circulo[0].interactable = true;
        circulo[1].interactable = true;
        circulo[2].interactable = true;
        circulo[3].interactable = true;
        sequencia = sequencia + bla;
        if (click >= 7)
        {
            StartCoroutine(Case3((int)Random.Range(0, 4)));
        }
    }
    IEnumerator Case3(int bla)
    {
        yield return new WaitForSeconds(0.5f);
        circulo[0].interactable = false;
        circulo[1].interactable = false;
        circulo[2].interactable = false;
        circulo[3].interactable = false;
        yield return new WaitForSeconds(2f);
        numeroCirculos++;
        circulo[bla].interactable = true;
        texto_puzzle2_1.text = "Contagem de círculos que brilharam: " + numeroCirculos;
        yield return new WaitForSeconds(2f);
        circulo[0].interactable = true;
        circulo[1].interactable = true;
        circulo[2].interactable = true;
        circulo[3].interactable = true;
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
        IC.panel0.SetActive(false);
        IC.panel1.SetActive(false);
        IC.panel2.SetActive(false);
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
    //----------------------------------------------------------------------------------------------------------------------------------------
}
