using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTeste : MonoBehaviour
{
    public Transform player;
    public float sensibilidadeX = 5f, sensibilidadeY = 10f, rotacaoX = 0f, rotacaoY = 0f;
    public bool enableMouse;

    private Vector3 offset;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {

    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        rotacaoX += Input.GetAxis("Mouse X") * sensibilidadeX;
        rotacaoY += Input.GetAxis("Mouse Y") * sensibilidadeY;

        transform.position = player.position + offset;
        transform.rotation = Quaternion.Euler(rotacaoX, rotacaoY, 0);
        //----------------------------------------------------------------------------------------------------------------------------------------
        if (enableMouse)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
