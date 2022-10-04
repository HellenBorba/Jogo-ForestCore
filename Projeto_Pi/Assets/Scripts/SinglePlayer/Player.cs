using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Player : MonoBehaviour
{
    public GameObject SenhaPuzzle0, textoAvisoPuzzle0;
    public int efs;

    private GameContoller GC;
    private Vector3 forward, strafe, vertical;
    private float forwardSpeed = 5, strafeSpeed = 5, gravity, jumpSpeed, maxJumpHeight = 2, timeToMaxHeight = 0.5f, minZ, minX, minY, maxY, maxX, maxZ;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        GC = GameObject.Find("GameController").GetComponent<GameContoller>();
        //----------------------------------------------------------------------------------------------------------------------------------------
        Cursor.visible = true;        
        //----------------------------------------------------------------------------------------------------------------------------------------
        gravity = (-2 * maxJumpHeight) / (timeToMaxHeight * timeToMaxHeight);
        jumpSpeed = (2 * maxJumpHeight) / timeToMaxHeight;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        #region Limite Mapa
        minZ = -26.647f;
        maxZ = -2.833f;

        minX = -17.957f;
        maxX = -2.38f;

        minY = 0.308f;
        maxY = 0.926f;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX),
                                        Mathf.Clamp(transform.position.y, minY, maxY),
                                        Mathf.Clamp(transform.position.z, minZ, maxZ));
        #endregion
        //----------------------------------------------------------------------------------------------------------------------------------------
        #region F
        if (efs == 0)
        {
            float forwardInput = Input.GetAxisRaw("Vertical");
            float strafeInput = Input.GetAxisRaw("Horizontal");

            forward = forwardInput * forwardSpeed * transform.forward;
            strafe = strafeInput * strafeSpeed * transform.right;

            transform.position += new Vector3(strafeInput * strafeSpeed, 0, forwardInput * forwardSpeed) * Time.deltaTime;

            vertical += gravity * Time.deltaTime * Vector3.up;
        }
        if(efs == 1)
        {
            GC.Camera[0].SetActive(false);
            GC.Camera[1].SetActive(true);

            float forwardInput = Input.GetAxisRaw("VerticalCam");
            float strafeInput = Input.GetAxisRaw("HorizontalCam");

            forward = forwardInput * forwardSpeed * transform.forward;
            strafe = strafeInput * strafeSpeed * transform.right;

            transform.position += new Vector3(strafeInput * strafeSpeed, 0, forwardInput * forwardSpeed) * Time.deltaTime;

            vertical += gravity * Time.deltaTime * Vector3.up;
        }
        else
        if(efs == 2)
        {
            GC.Camera[0].SetActive(true);
            GC.Camera[1].SetActive(false);

            float forwardInput = Input.GetAxisRaw("Vertical");
            float strafeInput = Input.GetAxisRaw("Horizontal");

            forward = forwardInput * forwardSpeed * transform.forward;
            strafe = strafeInput * strafeSpeed * transform.right;

            transform.position += new Vector3(strafeInput * strafeSpeed, 0, forwardInput * forwardSpeed) * Time.deltaTime;

            vertical += gravity * Time.deltaTime * Vector3.up;

            efs = 0;
        }else
        if(efs == 3)
        {
            float forwardInput = Input.GetAxisRaw("Vertical");
            float strafeInput = Input.GetAxisRaw("Horizontal");

            forward = forwardInput * forwardSpeed * transform.forward;
            strafe = strafeInput * strafeSpeed * transform.right;

            transform.position += new Vector3(strafeInput * strafeSpeed, 0, forwardInput * forwardSpeed) * Time.deltaTime;

            vertical += gravity * Time.deltaTime * Vector3.up;
            //----------------------------------------------------------------------------------------------------------------------------------------
            GC.Camera[2].SetActive(true);
            GC.Camera[0].SetActive(false);
            GC.Camera[1].SetActive(false);
            GC.Camera[3].SetActive(false);
        }else
        if(efs == 4)
        {
            float forwardInput = Input.GetAxisRaw("Vertical");
            float strafeInput = Input.GetAxisRaw("Horizontal");

            forward = forwardInput * forwardSpeed * transform.forward;
            strafe = strafeInput * strafeSpeed * transform.right;

            transform.position += new Vector3(strafeInput * strafeSpeed, 0, forwardInput * forwardSpeed) * Time.deltaTime;

            vertical += gravity * Time.deltaTime * Vector3.up;
            //----------------------------------------------------------------------------------------------------------------------------------------
            GC.Camera[0].SetActive(true);
            GC.Camera[1].SetActive(false);
            GC.Camera[2].SetActive(false);
            GC.Camera[3].SetActive(false);
            efs = 0;
        }
        if(Input.GetKeyDown(KeyCode.F))
        {
            efs += 1;
        }
        #endregion
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    #region Puzzle0
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
        SenhaPuzzle0.SetActive(true);
        yield return new WaitForSeconds(3f);
        SenhaPuzzle0.SetActive(false);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    IEnumerator AvisoPuzzle2()
    {
        yield return new WaitForSeconds(0f);
        textoAvisoPuzzle0.SetActive(true);
        yield return new WaitForSeconds(5f);
        textoAvisoPuzzle0.SetActive(false);
        Object.Destroy(textoAvisoPuzzle0);
    }
    #endregion
    //----------------------------------------------------------------------------------------------------------------------------------------
}
