using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public Rigidbody rig;
    public GameObject[] Objeto;
    public int nun;
    public GameObject ponto;

    [SerializeField]
    private float timer;
    public Color green;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 4)
        {
            gameObject.transform.position = ponto.transform.position;
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnMouseDown()
    {
        print("click");
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
