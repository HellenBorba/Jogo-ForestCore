using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody body;
    public GameObject SenhaPuzzle2, textoAvisoPuzzle2; 
    private float horizontal, vertical;

    private GameContoller GC;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GC = GameObject.Find("GameController").GetComponent<GameContoller>();
        //----------------------------------------------------------------------------------------------------------------------------------------
        Cursor.visible = false;
        //----------------------------------------------------------------------------------------------------------------------------------------
        body = GetComponent<Rigidbody>();
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        body.velocity = new Vector3(horizontal * 10, 0, vertical * 10);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    #region Puzzle2
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Senha"))
        {
            StartCoroutine(Senha());
            GC.puzzles[0].SetActive(true);
            GC.puzzles[1].SetActive(false);
        }
        if(collision.gameObject.CompareTag("FiosFim"))
        {
            StartCoroutine(AvisoPuzzle2());
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    IEnumerator Senha()
    {
        yield return new WaitForSeconds(0f);
        SenhaPuzzle2.SetActive(true);
        yield return new WaitForSeconds(3f);
        SenhaPuzzle2.SetActive(false);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    IEnumerator AvisoPuzzle2()
    {
        yield return new WaitForSeconds(0f);
        textoAvisoPuzzle2.SetActive(true);
        yield return new WaitForSeconds(5f);
        textoAvisoPuzzle2.SetActive(false);
        Object.Destroy(textoAvisoPuzzle2);
    }
    #endregion
    //----------------------------------------------------------------------------------------------------------------------------------------
}
