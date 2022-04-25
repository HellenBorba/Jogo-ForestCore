using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum tipoItem
{
    agua, meu
}

public class ItemCollect : MonoBehaviour
{
    public GameObject panel;
    public int Itemtipo;
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
                    SceneManager.LoadSceneAsync(0);
                    break;
            }
        }
    }
}
