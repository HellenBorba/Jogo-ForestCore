using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AvisoJgadores : MonoBehaviour
{
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void Game()
    {
        SceneManager.LoadScene("Game");
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void Menu()
    {
        SceneManager.LoadScene("Menu_Game");
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
