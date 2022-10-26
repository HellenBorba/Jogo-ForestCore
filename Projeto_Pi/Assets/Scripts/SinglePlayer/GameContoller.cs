using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameContoller : MonoBehaviour
{
    public GameObject[] buton, Camera, PaneisTutoriais, information, panel, portas, Puzzle0_Fios, Puzzle1_Poço, Puzzle2_Glicose;
    public Button[] interact, circulo;
    public Button CirculoStart;
    public Text texto_puzzle_1, texto_puzzle_0, texto_puzzle1_1;
    public Slider slider;
    
    private int click, quantidade, contagem, numeroCirculos;
    private string sequencia, valor, codigo;
    private ItemCollect IC;
    private Player PY;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        IC = GameObject.Find("poço").GetComponent<ItemCollect>();
        PY = GameObject.Find("Player_Game").GetComponent<Player>();
        //----------------------------------------------------------------------------------------------------------------------------------------
        Cursor.visible = true;
        //----------------------------------------------------------------------------------------------------------------------------------------
        interact[0].interactable = false;
        interact[1].interactable = false;
        interact[2].interactable = false;
        interact[3].interactable = false;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void Update()
    {
        #region ESC e G
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            panel[1].SetActive(false);
            panel[2].SetActive(false);
            panel[3].SetActive(false);
            panel[4].SetActive(false);
            panel[5].SetActive(false);
            panel[6].SetActive(false);
            Camera[3].SetActive(true);
            Camera[0].SetActive(false);
            Camera[1].SetActive(false);
            Camera[2].SetActive(false);
            Camera[4].SetActive(false);
            information[0].SetActive(true);
            IC.Player.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.G))
        {
            panel[1].SetActive(false);
            panel[2].SetActive(false);
            panel[3].SetActive(false);
            panel[4].SetActive(false);
            panel[5].SetActive(false);
            panel[6].SetActive(false);
            Camera[3].SetActive(true);
            Camera[0].SetActive(false);
            Camera[1].SetActive(false);
            Camera[2].SetActive(false);
            Camera[4].SetActive(false);
            information[1].SetActive(true);
            IC.Player.SetActive(false);
        }
        #endregion
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
        //----------------------------------------------------------------------------------------------------------------------------------------
        if (quantidade == 3)
        {
            Puzzle0_Fios[0].SetActive(false);
            portas[0].GetComponent<BoxCollider>().enabled = true;
            portas[1].GetComponent<BoxCollider>().enabled = true;
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
        texto_puzzle_0.text = "Código incorreto!";
        yield return new WaitForSeconds(1.5f);
        texto_puzzle_0.text = "Reinicie!";
        yield return new WaitForSeconds(3f);
        texto_puzzle_0.text = "";
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
                texto_puzzle_1.text = "Espere o círculo brilhar, e depois click no que brilhar!";
                texto_puzzle1_1.text = "1° onda";
                break;
            case 2:
                if(valor == sequencia)
                {
                    numeroCirculos = 0;
                    StartCoroutine(Case1((int)Random.Range(0, 4)));
                    texto_puzzle_1.text = "Espere os 2 círculos brilharem, e depois click nos 2 que brilharem!";
                    texto_puzzle1_1.text = "2° onda";
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
                    StartCoroutine(Case2_1((int)Random.Range(0, 4)));
                    texto_puzzle_1.text = "Espere os 3 círculos brilharem, e depois click nos 3 que brilharem!";
                    texto_puzzle1_1.text = "3° onda";
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
                    StartCoroutine(Case3_1((int)Random.Range(0, 4)));
                    texto_puzzle_1.text = "Espere os 4 círculos brilharem, e depois click nos 4 que brilharem!";
                    texto_puzzle1_1.text = "4° onda";
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
                    texto_puzzle1_1.text = "Fim!";
                    texto_puzzle_1.text = "Parabéns!";
                    slider.value += 2;
                    buton[1].SetActive(true);
                    Puzzle1_Poço[0].GetComponent<BoxCollider>().enabled = false;
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
    //-----------------------------------------------Corrotinas-------------------------------------------------------------------------------
    #region CaseP1-1
    IEnumerator Case(int bla)
    {
        yield return new WaitForSeconds(0.5f);
        circulo[0].interactable = false;
        circulo[1].interactable = false;
        circulo[2].interactable = false;
        circulo[3].interactable = false;
        yield return new WaitForSeconds(0.5f);
        numeroCirculos++;
        circulo[bla].interactable = true;
        texto_puzzle1_1.text = "Contagem de círculos que brilharam: " + numeroCirculos;
        sequencia = sequencia + bla;
        yield return new WaitForSeconds(0.5f);
        circulo[0].interactable = true;
        circulo[1].interactable = true;
        circulo[2].interactable = true;
        circulo[3].interactable = true;
    }
    #endregion
    #region CaseP1-2
    IEnumerator Case1(int bla)
    {
        yield return new WaitForSeconds(0.4f);
        circulo[0].interactable = false;
        circulo[1].interactable = false;
        circulo[2].interactable = false;
        circulo[3].interactable = false;
        yield return new WaitForSeconds(0.4f);
        numeroCirculos++;
        circulo[bla].interactable = true;
        texto_puzzle1_1.text = "Contagem de círculos que brilharam: " + numeroCirculos;
        sequencia = sequencia + bla;
        if (click >= 2)
        {
            StartCoroutine(Case1_2((int)Random.Range(0, 4)));
        }
    }
    IEnumerator Case1_2(int bla)
    {
        yield return new WaitForSeconds(0.4f);
        circulo[0].interactable = false;
        circulo[1].interactable = false;
        circulo[2].interactable = false;
        circulo[3].interactable = false;
        yield return new WaitForSeconds(0.4f);
        numeroCirculos++;
        circulo[bla].interactable = true;
        texto_puzzle1_1.text = "Contagem de círculos que brilharam: " + numeroCirculos;
        sequencia = sequencia + bla;
        yield return new WaitForSeconds(0.4f);
        circulo[0].interactable = true;
        circulo[1].interactable = true;
        circulo[2].interactable = true;
        circulo[3].interactable = true;
    }
    #endregion
    #region CaseP1-3
    IEnumerator Case2_1(int bla)
    {
        yield return new WaitForSeconds(0.3f);
        circulo[0].interactable = false;
        circulo[1].interactable = false;
        circulo[2].interactable = false;
        circulo[3].interactable = false;
        yield return new WaitForSeconds(0.3f);
        numeroCirculos++;
        circulo[bla].interactable = true;
        texto_puzzle1_1.text = "Contagem de círculos que brilharam: " + numeroCirculos;
        sequencia = sequencia + bla;
        yield return new WaitForSeconds(0.3f);
        circulo[0].interactable = false;
        circulo[1].interactable = false;
        circulo[2].interactable = false;
        circulo[3].interactable = false;
        if (click >= 4)
        {
            StartCoroutine(Case2_2((int)Random.Range(0, 4)));
        }
    }
    IEnumerator Case2_2(int bla)
    {
        yield return new WaitForSeconds(0.3f);
        circulo[0].interactable = false;
        circulo[1].interactable = false;
        circulo[2].interactable = false;
        circulo[3].interactable = false;
        yield return new WaitForSeconds(0.3f);
        numeroCirculos++;
        circulo[bla].interactable = true;
        texto_puzzle1_1.text = "Contagem de círculos que brilharam: " + numeroCirculos;
        sequencia = sequencia + bla;
        yield return new WaitForSeconds(0.3f);
        circulo[0].interactable = false;
        circulo[1].interactable = false;
        circulo[2].interactable = false;
        circulo[3].interactable = false;
        if (click >= 4)
        {
            StartCoroutine(Case2_3((int)Random.Range(0, 4)));
        }
    }
    IEnumerator Case2_3(int bla)
    {
        yield return new WaitForSeconds(0.3f);
        circulo[0].interactable = false;
        circulo[1].interactable = false;
        circulo[2].interactable = false;
        circulo[3].interactable = false;
        yield return new WaitForSeconds(0.3f);
        numeroCirculos++;
        circulo[bla].interactable = true;
        texto_puzzle1_1.text = "Contagem de círculos que brilharam: " + numeroCirculos;
        sequencia = sequencia + bla;
        yield return new WaitForSeconds(0.3f);
        circulo[0].interactable = true;
        circulo[1].interactable = true;
        circulo[2].interactable = true;
        circulo[3].interactable = true;
    }
    #endregion
    #region CaseP1-4
    IEnumerator Case3_1(int bla)
    {
        yield return new WaitForSeconds(0.2f);
        circulo[0].interactable = false;
        circulo[1].interactable = false;
        circulo[2].interactable = false;
        circulo[3].interactable = false;
        yield return new WaitForSeconds(0.2f);
        numeroCirculos++;
        circulo[bla].interactable = true;
        texto_puzzle1_1.text = "Contagem de círculos que brilharam: " + numeroCirculos;
        sequencia = sequencia + bla;
        yield return new WaitForSeconds(0.2f);
        circulo[0].interactable = false;
        circulo[1].interactable = false;
        circulo[2].interactable = false;
        circulo[3].interactable = false;
        if (click >= 4)
        {
            StartCoroutine(Case3_2((int)Random.Range(0, 4)));
        }
    }
    IEnumerator Case3_2(int bla)
    {
        yield return new WaitForSeconds(0.2f);
        circulo[0].interactable = false;
        circulo[1].interactable = false;
        circulo[2].interactable = false;
        circulo[3].interactable = false;
        yield return new WaitForSeconds(0.2f);
        numeroCirculos++;
        circulo[bla].interactable = true;
        texto_puzzle1_1.text = "Contagem de círculos que brilharam: " + numeroCirculos;
        sequencia = sequencia + bla;
        yield return new WaitForSeconds(0.2f);
        circulo[0].interactable = false;
        circulo[1].interactable = false;
        circulo[2].interactable = false;
        circulo[3].interactable = false;
        if (click >= 4)
        {
            StartCoroutine(Case3_3((int)Random.Range(0, 4)));
        }
    }
    IEnumerator Case3_3(int bla)
    {
        yield return new WaitForSeconds(0.2f);
        circulo[0].interactable = false;
        circulo[1].interactable = false;
        circulo[2].interactable = false;
        circulo[3].interactable = false;
        yield return new WaitForSeconds(0.2f);
        numeroCirculos++;
        circulo[bla].interactable = true;
        texto_puzzle1_1.text = "Contagem de círculos que brilharam: " + numeroCirculos;
        sequencia = sequencia + bla;
        yield return new WaitForSeconds(0.2f);
        circulo[0].interactable = false;
        circulo[1].interactable = false;
        circulo[2].interactable = false;
        circulo[3].interactable = false;
        if (click >= 4)
        {
            StartCoroutine(Case3_4((int)Random.Range(0, 4)));
        }
    }
    IEnumerator Case3_4(int bla)
    {
        yield return new WaitForSeconds(0.2f);
        circulo[0].interactable = false;
        circulo[1].interactable = false;
        circulo[2].interactable = false;
        circulo[3].interactable = false;
        yield return new WaitForSeconds(0.2f);
        numeroCirculos++;
        circulo[bla].interactable = true;
        texto_puzzle1_1.text = "Contagem de círculos que brilharam: " + numeroCirculos;
        sequencia = sequencia + bla;
        yield return new WaitForSeconds(0.2f);
        circulo[0].interactable = true;
        circulo[1].interactable = true;
        circulo[2].interactable = true;
        circulo[3].interactable = true;
    }
    #endregion
    //----------------------------------------------------------------------------------------------------------------------------------------
    IEnumerator OrdemIncorreta()
    {
        yield return new WaitForSeconds(0f);
        texto_puzzle_1.text = "Ordem errada! click novamente em start para recomeçar!";
        yield return new WaitForSeconds(5f);
        texto_puzzle_1.text = null;
    }
    #endregion
    //---------------------------------------------------------------------------------------------------------------------------------------- 
    #region Saida de Puzzles
    public void Panel()
    {
        panel[0].SetActive(false);
        panel[1].SetActive(false);
        panel[2].SetActive(false);
        panel[3].SetActive(false);
        panel[4].SetActive(false);
        panel[5].SetActive(false);
        panel[6].SetActive(false);
        Camera[0].SetActive(true);
        Camera[1].SetActive(false);
        Camera[2].SetActive(false);
        Camera[3].SetActive(false);
        Camera[4].SetActive(false);
        IC.Player.SetActive(true);
    }
    #endregion
    //----------------------------------------------------------------------------------------------------------------------------------------
    #region Vitória
    IEnumerator Vitória()
    {
        yield return new WaitForSeconds(0f);
        panel[6].SetActive(true);
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(0);
    }
    public void vitoria(int num)
    {
        contagem += num;
    }
    #endregion
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void VoltaMenu()
    {
        SceneManager.LoadScene("Menu_Game");
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}

