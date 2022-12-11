
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameContoller : MonoBehaviour
{
    public GameObject[] buton, Camera, PaneisTutoriais, information, panel, portas, Puzzle0_Fios, Puzzle1_Po�o, Puzzle2_Glicose;
    public GameObject SpawnPlayerAqui;
    public Button[] interact, circulo;
    public Button CirculoStart;
    public Text texto_puzzle_1, texto_puzzle1_1, texto_puzzle_0, texto_puzzle0_1, Informa��oPontos, Tutorial_hist�ria;
    public Slider slider, Glicose, �gua;
    public Animator aminPD, aminPE;
    public float timerTutorial;
    public int click, quantidade, contagemG, contagemA, numeroCirculos, idEsc, idM, idG, ordemdevir;
    public string sequencia, valor, codigo;

    private ItemCollect IC;
    private Player PY;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        IC = GameObject.Find("po�o").GetComponent<ItemCollect>();
        PY = GameObject.Find("Player_Game").GetComponent<Player>();
        //----------------------------------------------------------------------------------------------------------------------------------------
        vem();
        //----------------------------------------------------------------------------------------------------------------------------------------
        Cursor.visible = true;
        //----------------------------------------------------------------------------------------------------------------------------------------
        contagemA = 40;
        contagemG = 40;
        //----------------------------------------------------------------------------------------------------------------------------------------
        Puzzle2_Glicose[0].GetComponent<BoxCollider>().enabled = false;
        Puzzle1_Po�o[0].GetComponent<BoxCollider>().enabled = false;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void Update()
    {
        if(contagemG >= 100 && contagemA >= 100)
        {
            StartCoroutine(Vit�ria());
        }
        if(contagemA <= 0 || contagemG <= 0)
        {
            StartCoroutine(Derrota());
        }
        //----------------------------------------------------------------------------------------------------------------------------------------
        if (timerTutorial <= 40)
        {
            timerTutorial += Time.deltaTime;
        }
        #region ESC, M e G
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            idEsc += 1;
            if (idEsc == 2)
            {
                information[0].SetActive(false);
                panel[1].SetActive(false);
                panel[2].SetActive(false);
                panel[3].SetActive(false);
                panel[4].SetActive(false);
                panel[5].SetActive(false);
                panel[6].SetActive(false);
                Camera[0].SetActive(false);
                Camera[1].SetActive(false);
                Camera[2].SetActive(false);
                IC.Player.SetActive(true);
                PaneisTutoriais[2].SetActive(false);
                idEsc = 0;
            }
            if (idEsc == 1)
            {
                Camera[1].SetActive(true);
                StartCoroutine(Esc());
            }
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            idM += 1;
            if (idM == 2)
            {
                information[1].SetActive(false);
                panel[1].SetActive(false);
                panel[2].SetActive(false);
                panel[3].SetActive(false);
                panel[4].SetActive(false);
                panel[5].SetActive(false);
                panel[6].SetActive(false);
                Camera[1].SetActive(false);
                Camera[0].SetActive(false);
                Camera[2].SetActive(false);
                IC.Player.SetActive(true);
                PaneisTutoriais[2].SetActive(false);
                idM = 0;
            }
            if (idM == 1)
            {
                Camera[1].SetActive(true);
                StartCoroutine(M());
            }
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            idG += 1;
            if (idG == 1)
            {
                Puzzle0_Fios[1].SetActive(true);
                PaneisTutoriais[2].SetActive(false);
            }
            if (idG == 2)
            {
                Puzzle0_Fios[1].SetActive(false);
                idG = 0;
            }
        }
        #endregion
        //----------------------------------------------------------------------------------------------------------------------------------------
        #region Puzzle0
        if (quantidade == 4)
        {
            if (codigo != "4132")
            {
                StartCoroutine(Puzzle1Final());
                interact[0].interactable = true;
                interact[1].interactable = true;
                interact[2].interactable = true;
                interact[3].interactable = true;
                texto_puzzle0_1.text = "";
                codigo = null;
                quantidade = 0;
                contagemA -= 10;
                contagemG -= 10;
                StartCoroutine(Puzzle0_Informa��oD());
            }
        }
        #endregion
        //----------------------------------------------------------------------------------------------------------------------------------------
        Glicose.value = contagemG;
        �gua.value = contagemA;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    #region Puzzle0
    public void Seleciono(int numBotao)
    {
        codigo = codigo + numBotao;
        if (codigo == "4132")
        { 
            buton[0].SetActive(true);

            Puzzle2_Glicose[0].GetComponent<BoxCollider>().enabled = true;
            Puzzle1_Po�o[0].GetComponent<BoxCollider>().enabled = true;
            Puzzle0_Fios[0].GetComponent<BoxCollider>().enabled = false;

            portas[0].GetComponent<BoxCollider>().enabled = true;
            portas[1].GetComponent<BoxCollider>().enabled = true;

            StartCoroutine(Puzzle0_Informa��oV());

            aminPD.SetFloat("Habilita", 1);
            aminPE.SetFloat("Habilita", 1);
            StartCoroutine(Anima��oPortas());
            PaneisTutoriais[2].SetActive(false);

            contagemG += 15;
            contagemA += 15;
        }
        texto_puzzle0_1.text = "" + codigo;
        //----------------------------------------------------------------------------------------------------------------------------------------
        switch (numBotao)
        {
            // 4 - 1 - 3 - 2
            case 1:
                quantidade += 1;
                interact[0].interactable = true;
                break;
            case 2:
                quantidade += 1;
                interact[1].interactable = true;
                break;
            case 3:
                quantidade += 1;
                interact[2].interactable = true;
                break;
            case 4:
                quantidade += 1;
                interact[3].interactable = true;
                break;
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    IEnumerator Puzzle1Final()
    {
        yield return new WaitForSeconds(0f);
        texto_puzzle_0.text = "C�digo incorreto!";
        yield return new WaitForSeconds(1.5f);
        texto_puzzle_0.text = "Reinicie!";
        yield return new WaitForSeconds(3f);
        texto_puzzle_0.text = "";
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    IEnumerator Anima��oPortas()
    {
        yield return new WaitForSeconds(1f);
        portas[0].GetComponent<BoxCollider>().enabled = false;
        portas[1].GetComponent<BoxCollider>().enabled = false;
        IC.TextoDoJog.SetActive(false);
    }
    #endregion
    //----------------------------------------------------------------------------------------------------------------------------------------
    #region Puzzle1
    public void N�mero1(int val)
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
                texto_puzzle_1.text = "Espere o c�rculo brilhar, e depois click no que brilhar!";
                texto_puzzle1_1.text = "1� onda";
                break;
            case 2:
                if (valor == sequencia)
                {
                    numeroCirculos = 0;
                    StartCoroutine(Case1((int)Random.Range(0, 4)));
                    texto_puzzle_1.text = "Espere os 2 c�rculos brilharem, e depois click nos 2 que brilharem!";
                    texto_puzzle1_1.text = "2� onda";
                    slider.value += 1;
                }
                else
                {
                    StartCoroutine(OrdemIncorreta());
                    click = 0;
                    sequencia = null;
                    valor = null;
                    slider.value = 0;
                    numeroCirculos = 0;
                    StartCoroutine(Puzzle1_Informa��esD());
                }
                break;
            case 4:
                if (valor == sequencia)
                {
                    numeroCirculos = 0;
                    StartCoroutine(Case2_1((int)Random.Range(0, 4)));
                    texto_puzzle_1.text = "Espere os 3 c�rculos brilharem, e depois click nos 3 que brilharem!";
                    texto_puzzle1_1.text = "3� onda";
                    slider.value += 1;
                }
                else
                {
                    StartCoroutine(OrdemIncorreta());
                    click = 0;
                    sequencia = null;
                    valor = null;
                    slider.value = 0;
                    numeroCirculos = 0;
                    StartCoroutine(Puzzle1_Informa��esD());
                }
                break;
            case 7:
                if (valor == sequencia)
                {
                    numeroCirculos = 0;
                    StartCoroutine(Case3_1((int)Random.Range(0, 4)));
                    texto_puzzle_1.text = "Espere os 4 c�rculos brilharem, e depois click nos 4 que brilharem!";
                    texto_puzzle1_1.text = "4� onda";
                    slider.value += 1;
                }
                else
                {
                    StartCoroutine(OrdemIncorreta());
                    click = 0;
                    sequencia = null;
                    valor = null;
                    slider.value = 0;
                    numeroCirculos = 0;
                    StartCoroutine(Puzzle1_Informa��esD());
                }
                break;
            case 11:
                if (valor == sequencia)
                {
                    texto_puzzle1_1.text = "Fim!";
                    texto_puzzle_1.text = "Parab�ns!";
                    slider.value += 2;
                    buton[1].SetActive(true);
                    click = 0;
                    sequencia = null;
                    valor = null;
                    slider.value = 0;
                    numeroCirculos = 0;
                    StartCoroutine(Puzzle1_Informa��esV());
                    contagemA += 20;
                }
                else
                {
                    StartCoroutine(OrdemIncorreta());
                    click = 0;
                    sequencia = null;
                    valor = null;
                    slider.value = 0;
                    numeroCirculos = 0;
                    StartCoroutine(Puzzle1_Informa��esD());
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
        texto_puzzle1_1.text = "Contagem de c�rculos que brilharam: " + numeroCirculos;
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
        texto_puzzle1_1.text = "Contagem de c�rculos que brilharam: " + numeroCirculos;
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
        texto_puzzle1_1.text = "Contagem de c�rculos que brilharam: " + numeroCirculos;
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
        texto_puzzle1_1.text = "Contagem de c�rculos que brilharam: " + numeroCirculos;
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
        texto_puzzle1_1.text = "Contagem de c�rculos que brilharam: " + numeroCirculos;
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
        texto_puzzle1_1.text = "Contagem de c�rculos que brilharam: " + numeroCirculos;
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
        texto_puzzle1_1.text = "Contagem de c�rculos que brilharam: " + numeroCirculos;
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
        texto_puzzle1_1.text = "Contagem de c�rculos que brilharam: " + numeroCirculos;
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
        texto_puzzle1_1.text = "Contagem de c�rculos que brilharam: " + numeroCirculos;
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
        texto_puzzle1_1.text = "Contagem de c�rculos que brilharam: " + numeroCirculos;
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
        contagemA -= 10;
        texto_puzzle_1.text = "Ordem errada! click novamente em start para recome�ar!";
        yield return new WaitForSeconds(5f);
        texto_puzzle_1.text = null;
    }
    #endregion
    //---------------------------------------------------------------------------------------------------------------------------------------- 
    #region saindo das Casas
    public void SairCasas()
    {
        panel[0].SetActive(false);
        panel[1].SetActive(false);
        panel[2].SetActive(false);
        panel[3].SetActive(false);
        panel[4].SetActive(false);
        panel[5].SetActive(false);
        panel[6].SetActive(false);
        Camera[0].SetActive(false);
        Camera[1].SetActive(false);
        Camera[2].SetActive(false);
        IC.Player.SetActive(true);
        Puzzle0_Fios[1].SetActive(false);
        information[0].SetActive(false);
        information[1].SetActive(false);
        PaneisTutoriais[2].SetActive(false);
        PY.efs2 = 0;
        PY.efs = 0;
        IC.TextoDoJog.SetActive(false);
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
        Camera[0].SetActive(false);
        Camera[1].SetActive(false);
        Camera[2].SetActive(false);
        IC.Player.SetActive(true);
        Puzzle0_Fios[1].SetActive(false);
        information[0].SetActive(false);
        information[1].SetActive(false);
    }
    #endregion
    //----------------------------------------------------------------------------------------------------------------------------------------
    #region Vit�ria/Derrota/ContagemPontos
    IEnumerator Vit�ria()
    {
        yield return new WaitForSeconds(0f);
        panel[6].SetActive(true);
        Camera[1].SetActive(true);
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Menu_Game");
    }
    IEnumerator Derrota()
    {
        yield return new WaitForSeconds(0f);
        Camera[1].SetActive(true);
        panel[5].SetActive(true);
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Menu_Game");
    }
    #endregion
    //----------------------------------------------------------------------------------------------------------------------------------------
    #region Inicio
    public void vem()
    {
        switch (ordemdevir)
        {
            case 0:
                IC.Player.SetActive(false);
                Camera[3].SetActive(true);
                Tutorial_hist�ria.text = "Ol�! Seja bem vindo (a) ao Forest Core.";
                StartCoroutine(Tutorial(3));
                break;
            case 1:
                Tutorial_hist�ria.text = "Vamos come�ar a jogar!";
                StartCoroutine(Tutorial(3));

                break;
            case 2:
                Tutorial_hist�ria.text = "O seu objetivo � salvar a �rvore da vida!";
                StartCoroutine(Tutorial(5));
                Camera[2].SetActive(true);
                Camera[3].SetActive(false);
                break;
            case 3:
                Tutorial_hist�ria.text = "Para isso vamos usar a bioenerg�tica.";
                StartCoroutine(Tutorial(5));
                break;
            case 4:
                Tutorial_hist�ria.text = "Voc� vai ajudar a planta a fazer fotoss�ntese!";
                StartCoroutine(Tutorial(5));
                break;
            case 5:
                Tutorial_hist�ria.text = "Precisa de �gua!";
                StartCoroutine(Tutorial(3));
                Camera[2].SetActive(false);
                Camera[3].SetActive(false);
                Camera[4].SetActive(true);
                break;
            case 6:
                Tutorial_hist�ria.text = "E tamb�m a ajudar a planta a produzir Glicose!";
                StartCoroutine(Tutorial(5));
                Camera[4].SetActive(false);
                Camera[0].SetActive(true);
                break;
            case 7:
                Tutorial_hist�ria.text = "Cada tarefa que voc� errar, PERDER� �gua ou glicose.";
                StartCoroutine(Tutorial(5));
                Camera[3].SetActive(true);
                Camera[0].SetActive(false);
                break;
            case 8:
                StartCoroutine(Tutorial(5));
                PaneisTutoriais[4].SetActive(false);
                panel[7].SetActive(true);
                break;
            case 9:
                StartCoroutine(Tutorial(5));
                PaneisTutoriais[4].SetActive(true);
                Tutorial_hist�ria.text = "E cada correta GANHAR� �gua ou glicose!";
                panel[7].SetActive(false);
                break;
            case 10:
                Tutorial_hist�ria.text = "Lembrando que para vencer, voc� precisa ter cheio a �gua e a glicose.";
                StartCoroutine(Tutorial(7));
                break;
            case 11:
                Tutorial_hist�ria.text = "Hora de fazer a 1� tarefa!";
                StartCoroutine(Tutorial(5));
                break;
            case 12:
                Tutorial_hist�ria.text = "V� at� a estufa que se encontra no canto superior direito do mapa!";
                StartCoroutine(Tutorial(7));
                break;
            case 13:
                IC.Player.SetActive(true);
                PaneisTutoriais[4].SetActive(false);
                Camera[3].SetActive(false);
                PaneisTutoriais[2].SetActive(true);
                break;
        }
    }
    #endregion
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void VoltaMenu()
    {
        SceneManager.LoadScene("Menu_Game");
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    IEnumerator Tutorial(float tempo)
    {
        yield return new WaitForSeconds(tempo);
        vem();
        ordemdevir += 1;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    #region Paineis Aparecem
    IEnumerator Esc()
    {
        yield return new WaitForSeconds(1.5f);
        information[0].SetActive(true);
        panel[1].SetActive(false);
        panel[2].SetActive(false);
        panel[3].SetActive(false);
        panel[4].SetActive(false);
        panel[5].SetActive(false);
        panel[6].SetActive(false);
        Camera[0].SetActive(false);
        Camera[2].SetActive(false);
        IC.Player.SetActive(false);
        PaneisTutoriais[2].SetActive(false);
    }
    IEnumerator M()
    {
        yield return new WaitForSeconds(1.5f);
        information[1].SetActive(true);
        panel[1].SetActive(false);
        panel[2].SetActive(false);
        panel[3].SetActive(false);
        panel[4].SetActive(false);
        panel[5].SetActive(false);
        panel[6].SetActive(false);
        Camera[0].SetActive(false);
        Camera[1].SetActive(false);
        Camera[2].SetActive(false);
        IC.Player.SetActive(false);
        PaneisTutoriais[2].SetActive(false);
    }
    IEnumerator Puzzle0_Informa��oD()
    {
        yield return new WaitForSeconds(0f);
        PaneisTutoriais[2].SetActive(true);
        Informa��oPontos.text = "-20 de vida";
        yield return new WaitForSeconds(1.5f);
        PaneisTutoriais[2].SetActive(false);
    }
    IEnumerator Puzzle0_Informa��oV()
    {
        yield return new WaitForSeconds(0f);
        PaneisTutoriais[2].SetActive(true);
        Informa��oPontos.text = "+30 de vida";
        yield return new WaitForSeconds(1.5f);
        PaneisTutoriais[2].SetActive(false);
    }
    IEnumerator Puzzle1_Informa��esD()
    {
        yield return new WaitForSeconds(0f);
        PaneisTutoriais[2].SetActive(true);
        Informa��oPontos.text = "-10 de �gua";
        yield return new WaitForSeconds(1.5f);
        PaneisTutoriais[2].SetActive(false);
    }
    IEnumerator Puzzle1_Informa��esV()
    {
        yield return new WaitForSeconds(0f);
        PaneisTutoriais[2].SetActive(true);
        Informa��oPontos.text = "+20 de �gua";
        yield return new WaitForSeconds(1.5f);
        PaneisTutoriais[2].SetActive(false);
    }
    public void Puzzle2_Informa��es2D()
    {
        StartCoroutine(Puzzle2_Informa��esD());
        IEnumerator Puzzle2_Informa��esD()
        {
            yield return new WaitForSeconds(0f);
            PaneisTutoriais[2].SetActive(true);
            Informa��oPontos.text = "-10 de glicose";
            yield return new WaitForSeconds(1.5f);
            PaneisTutoriais[2].SetActive(false);
        }
    }
    public void Puzzle2_Informa��es2V()
    {
        StartCoroutine(Puzzle2_Informa��esV());
        IEnumerator Puzzle2_Informa��esV()
        {
            yield return new WaitForSeconds(0f);
            PaneisTutoriais[2].SetActive(true);
            Informa��oPontos.text = "+20 de glicose";
            contagemG += 30;
            yield return new WaitForSeconds(1.5f);
            PaneisTutoriais[2].SetActive(false);
        }
    }
    #endregion
    //----------------------------------------------------------------------------------------------------------------------------------------
}
