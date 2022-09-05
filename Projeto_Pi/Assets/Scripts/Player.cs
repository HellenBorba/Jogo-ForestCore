using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject SenhaPuzzle2, textoAvisoPuzzle2; 

    private GameContoller GC;
    private Vector3 forward, strafe, vertical;
    private float forwardSpeed = 5, strafeSpeed = 5, gravity, jumpSpeed, maxJumpHeight = 2, timeToMaxHeight = 0.5f, minZ, minX, minY, maxY, maxX, maxZ;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GC = GameObject.Find("GameController").GetComponent<GameContoller>();
        //----------------------------------------------------------------------------------------------------------------------------------------
        Cursor.visible = false;
        //----------------------------------------------------------------------------------------------------------------------------------------
        gravity = (-2 * maxJumpHeight) / (timeToMaxHeight * timeToMaxHeight);
        jumpSpeed = (2 * maxJumpHeight) / timeToMaxHeight;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        float forwardInput = Input.GetAxisRaw("Vertical");
        float strafeInput = Input.GetAxisRaw("Horizontal");

        forward = forwardInput * forwardSpeed * transform.forward;
        strafe = strafeInput * strafeSpeed * transform.right;

        transform.position += new Vector3(strafeInput * strafeSpeed, 0, forwardInput * forwardSpeed) * Time.deltaTime;
        
        vertical += gravity * Time.deltaTime * Vector3.up;
        //----------------------------------------------------------------------------------------------------------------------------------------
        minZ = -26.647f;
        maxZ = -2.833f;

        minX = -17.957f;
        maxX = -2.38f;

        minY = 0.308f;
        maxY = 0.926f;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX),
                                        Mathf.Clamp(transform.position.y, minY, maxY),
                                        Mathf.Clamp(transform.position.z, minZ, maxZ));
        //----------------------------------------------------------------------------------------------------------------------------------------
        if(Input.GetKeyDown(KeyCode.W))
        {
            GC.Camera[0].SetActive(true);
            GC.Camera[1].SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            GC.Camera[1].SetActive(true);
            GC.Camera[0].SetActive(false);
        }
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
