using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour
{
    public AudioSource musica;
    public AudioSource SomM;
    public GameObject som, panel1, panel2, cam0, cam1, cam2;

    private int valVida;

    private int id, id2;
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void Start()
    {
        cam0.SetActive(false);
        cam1.SetActive(true);
        panel1.SetActive(true);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void Exit()
    {
        Application.Quit();
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void MultiPlayer()
    {
        SceneManager.LoadScene("Loading");
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void opções()
    {
        cam0.SetActive(false);
        cam2.SetActive(true);
        panel1.SetActive(false);
        panel2.SetActive(true);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void voltar()
    {
        cam2.SetActive(false);
        cam1.SetActive(true);
        panel1.SetActive(true);
        panel2.SetActive(false);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void MuteM()
    {
        if (id == 1)
        {
            musica.mute = true;
        }
        if(id == 2)
        {
            musica.mute = false;
            id = 0;
        }
    }
    public void valorM(int num)
    {
        id += num;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void MuteS()
    {
        if (id2 == 1)
        {
            SomM.mute = true;
        }
        if (id2 == 2)
        {
            SomM.mute = false;
            id2 = 0;
        }
    }
    public void toca()
    {
        StartCoroutine(tocaS());
    }
    IEnumerator tocaS()
    {
        yield return new WaitForSeconds(0f);
        som.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        som.SetActive(false);
    }
    public void valorS(int num)
    {
        id2 += num;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void DificuldadeF()
    {
        valVida = 2;
        PlayerPrefs.SetInt("vida", valVida);
    }    
    public void DificuldadeN()
    {
        valVida = 6;
        PlayerPrefs.SetInt("vida", valVida);
    }    
    public void DificuldadeD()
    {
        valVida = 10;
        PlayerPrefs.SetInt("vida", valVida);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void Tela1()
    {
        Screen.SetResolution(3000, 1800, true);
    }    
    public void Tela2()
    {
        Screen.SetResolution(1000, 1200, true);
    }    
    public void Tela3()
    {
        Screen.SetResolution(1200, 1200, true);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
