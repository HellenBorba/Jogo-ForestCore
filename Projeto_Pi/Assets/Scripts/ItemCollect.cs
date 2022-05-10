using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ItemCollect : MonoBehaviour
{
    public GameObject panel;
    public Scrollbar scrollbar;

    [SerializeField]
    private int Itemtipo, id;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {

    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
      

    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            switch (Itemtipo)
            {
                case 0:
                    //SceneManager.LoadScene (1, LoadSceneMode.Additive);
                    panel.SetActive(true);
                    break;
                case 1:
                    panel.SetActive(true);
                    scrollbar.value = id;
                    break;
                case 2:
                    panel.SetActive(true);
                    break;
            }
        }
    }
}
