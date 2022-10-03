using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Player_Multiplayer : MonoBehaviourPunCallbacks
{
    //public GameObject SenhaPuzzle0, textoAvisoPuzzle0; 

    private GameContoller_Multiplayer GCM;
    private Vector3 forward, strafe, vertical;
    private float forwardSpeed = 5, strafeSpeed = 5, gravity, jumpSpeed, maxJumpHeight = 2, timeToMaxHeight = 0.5f, minZ, minX, minY, maxY, maxX, maxZ;
    private int efs;

    PhotonView view;

    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        view = gameObject.GetComponent<PhotonView>();
        //----------------------------------------------------------------------------------------------------------------------------------------
        GCM = GameObject.Find("GameController_Multiplayer").GetComponent<GameContoller_Multiplayer>();
        //----------------------------------------------------------------------------------------------------------------------------------------
        Cursor.visible = true;
        //----------------------------------------------------------------------------------------------------------------------------------------
        gravity = (-2 * maxJumpHeight) / (timeToMaxHeight * timeToMaxHeight);
        jumpSpeed = (2 * maxJumpHeight) / timeToMaxHeight;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        if (view.IsMine)
        {
            float forwardInput = Input.GetAxisRaw("Vertical_Multiplayer");
            float strafeInput = Input.GetAxisRaw("Horizontal_Multiplayer");

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
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    #region Puzzle0
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Senha"))
        {
            StartCoroutine(Senha());
            GCM.puzzles[0].SetActive(true);
            GCM.puzzles[1].SetActive(false);
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
        //SenhaPuzzle0.SetActive(true);
        yield return new WaitForSeconds(3f);
        //SenhaPuzzle0.SetActive(false);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    IEnumerator AvisoPuzzle2()
    {
        yield return new WaitForSeconds(0f);
        //textoAvisoPuzzle0.SetActive(true);
        yield return new WaitForSeconds(5f);
        //textoAvisoPuzzle0.SetActive(false);
        //Object.Destroy(textoAvisoPuzzle0);
    }
    #endregion
    //----------------------------------------------------------------------------------------------------------------------------------------
}
