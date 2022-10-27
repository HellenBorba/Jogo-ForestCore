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
    public void Tela()
    {
        if (id2 == 1)
        {
            Screen.fullScreen = true;
        }
        if(id2 == 2)
        {
            Screen.fullScreen = false;
            id2 = 0;
        }
    }    
    public void Tela(int nam)
    {
        id2 += nam;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
