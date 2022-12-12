using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_GameLabirinto : MonoBehaviour
{
    public float velocidadeX, velocidadeY;

    private float horizontal, vertical;
    private Rigidbody2D body;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");

        body.velocity = new Vector2(horizontal * velocidadeX, vertical * velocidadeY); 
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("FinalL"))
        {
            SceneManager.LoadScene(0);
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
