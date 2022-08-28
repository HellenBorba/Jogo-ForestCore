using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour
{
    public AudioSource musica;
    public AudioSource SomM;
    public GameObject som;
    public int valVida;
    public float sensibility;
    public Vector3 rotation;

    private Núcleo NC;
    private int id, id2;
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void Start()
    {
        NC = GameObject.Find("Núcleo").GetComponent<Núcleo>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void Exit()
    {
        Application.Quit();
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
        Screen.SetResolution(500, 500, true);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void Mouse()
    {
        float _yMouse = Input.GetAxisRaw("Mouse X");
        rotation = new Vector3(0, _yMouse, 0) * sensibility;
    }
}
