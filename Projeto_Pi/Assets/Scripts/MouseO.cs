using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseO : MonoBehaviour
{
    //public Rigidbody rig;
    public GameObject[] Objeto;
    public GameObject pontoFixo;

    [SerializeField]
    private int vl;
    public Color green;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        switch (vl)
        {
            case 1:
                gameObject.transform.position = Objeto[0].transform.position;
                if (gameObject.transform.position == Objeto[0].transform.position)
                {
                    Color a = green;
                    Objeto[0].GetComponent<SpriteRenderer>().color = a;
                }
                break;
            case 2:
                gameObject.transform.position = pontoFixo.transform.position;
                break;
            case 3:
                gameObject.transform.position = Objeto[1].transform.position;
                Color b = green;
                Objeto[1].GetComponent<SpriteRenderer>().color = b;
                break;
            case 4:
                gameObject.transform.position = pontoFixo.transform.position;
                break;
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnMouseDown()
    {
        vl += 1;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnMouseDrag()
        {
        //----------------------------------------------------------------------------------------------------------------------------------------
        /*
        print("drag");
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        transform.position = new Vector2(mousePos.x, mousePos.y)s;
        print("oi");

        /rig.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, - Camera.main.transform.position.z));
         */
    }
}
