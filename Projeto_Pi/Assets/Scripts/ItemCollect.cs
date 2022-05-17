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
    private GameContoller GC;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GC = GameObject.Find("GameController").GetComponent<GameContoller>();
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
                    GC.Camera1.SetActive(false);
                    GC.Camera2.SetActive(true);
                    Cursor.visible = true;
                    //SceneManager.LoadScene (1, LoadSceneMode.Additive);
                    panel.SetActive(true);
                    break;
                case 1:
                    Cursor.visible = true;
                    panel.SetActive(true);
                    scrollbar.value = id;
                    break;
                case 2:
                    Cursor.visible = true;
                    panel.SetActive(true);
                    break;
            }
        }
    }
}
