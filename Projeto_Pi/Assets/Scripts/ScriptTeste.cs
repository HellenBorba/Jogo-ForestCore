using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTeste : MonoBehaviour
{
    public Transform player;
    public float sensibilidadeX = 5f, sensibilidadeY = 10f, rotacaoX = 0f, rotacaoY = 0f;

    private Vector3 offset;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        offset = player.position - transform.position + new Vector3(0, 2, 10f);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        rotacaoX += Input.GetAxis("Mouse X") * sensibilidadeX;
        rotacaoY += Input.GetAxis("Mouse Y") * sensibilidadeY;

        transform.position = player.position + offset;
        transform.rotation = Quaternion.Euler(rotacaoX, rotacaoY, 0);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------[
}
