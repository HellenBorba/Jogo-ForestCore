using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Núcleo_Multiplayer : MonoBehaviour
{
    public Slider barraVida;
    public GameObject PanelDerrota;

    private float timer, tempoFeito;
    private MenuScene MS;
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void Start()
    {
        MS = GameObject.Find("GameController_Menu").GetComponent<MenuScene>();
    }
    void Update()
    {
        tempoFeito += Time.deltaTime;
        timer += Time.deltaTime;
        //----------------------------------------------------------------------------------------------------------------------------------------
        if (timer >= 5)
        {
            barraVida.value -= PlayerPrefs.GetInt("vida");
            timer = 0;
        }
        //----------------------------------------------------------------------------------------------------------------------------------------
        if (barraVida.value == 0)
        {
            StartCoroutine(Derrota());
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    IEnumerator Derrota()
    {
        yield return new WaitForSeconds(0f);
        PanelDerrota.SetActive(true);
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(0);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
