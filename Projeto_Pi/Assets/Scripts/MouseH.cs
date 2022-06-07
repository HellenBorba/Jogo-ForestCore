using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseH : MonoBehaviour
{
    public GameObject[] Objeto;
    public int nun;
    public GameObject pontoFixo;

    [SerializeField]
    private int vh;
    public Color green;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {

    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        if (vh == 2)
        {
            gameObject.transform.position = pontoFixo.transform.position;
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnMouseDown()
    {
        vh += 1;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnMouseDrag()
    {
        gameObject.transform.position = Objeto[0].transform.position;
        switch (nun)
        {
            case 0:
                if (gameObject.transform.position == Objeto[0].transform.position)
                {
                    Color c = green;
                    Objeto[0].GetComponent<SpriteRenderer>().color = c;
                }
                break;
        }
    }
}
