using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject SenhaPuzzle2, textoAvisoPuzzle2; 
    private GameContoller GC;

    private CharacterController controller;
    private Vector3 forward, strafe, vertical;
    public float forwardSpeed = 5, strafeSpeed = 5;
    private float gravity, jumpSpeed;
    public float maxJumpHeight = 2, timeToMaxHeight = 0.5f;

    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GC = GameObject.Find("GameController").GetComponent<GameContoller>();
        //----------------------------------------------------------------------------------------------------------------------------------------
        Cursor.visible = false;
        //----------------------------------------------------------------------------------------------------------------------------------------
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        controller = GetComponent<CharacterController>();
        gravity = (-2 * maxJumpHeight) / (timeToMaxHeight * timeToMaxHeight);
        jumpSpeed = (2 * maxJumpHeight) / timeToMaxHeight;

    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        float forwardInput = Input.GetAxisRaw("Vertical");
        float strafeInput = Input.GetAxisRaw("Horizontal");

        print(Input.GetAxisRaw("Vertical"));

        forward = forwardInput * forwardSpeed * transform.forward;
        strafe = strafeInput * strafeSpeed * transform.right;

        transform.position += new Vector3(strafeInput * strafeSpeed, 0, forwardInput * forwardSpeed) * Time.deltaTime;
        
        vertical += gravity * Time.deltaTime * Vector3.up;
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
