using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum tipoItem
{
    agua, meu
}

public class ItemCollect : MonoBehaviour
{
    public GameObject panel;
    public int Itemtipo, Contagem, id;
    public Scrollbar scrollbar;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      

    }
         
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
