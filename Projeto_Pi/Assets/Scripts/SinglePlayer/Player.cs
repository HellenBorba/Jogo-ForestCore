using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.Animations;
[RequireComponent(typeof(CharacterController))]

public class Player : MonoBehaviour
{
    public GameObject SenhaPuzzle0;
    public int efs;
    public Animator amin1;
    CharacterController controller;

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
        controller = GetComponent<CharacterController>();
        gravity = (-2 * maxJumpHeight) / (timeToMaxHeight * timeToMaxHeight);
        jumpSpeed = (4 * maxJumpHeight) / timeToMaxHeight;
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Update()
    {
        #region Limite Mapa
        minZ = -26.647f;
        maxZ = -2.833f;

        minX = -17.957f;
        maxX = -3.2f;

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

            vertical += gravity * Time.deltaTime * Vector3.up;

            Vector3 finalVelocity = forward + strafe + vertical;
            controller.Move(finalVelocity * Time.deltaTime);
        }

        if (efs == 1)
        {
            GC.Camera[0].SetActive(false);
            GC.Camera[1].SetActive(true);

            float forwardInput = Input.GetAxisRaw("VerticalCam");
            float strafeInput = Input.GetAxisRaw("HorizontalCam");

            forward = forwardInput * forwardSpeed * transform.forward;
            strafe = strafeInput * strafeSpeed * transform.right;

            vertical += gravity * Time.deltaTime * Vector3.up;

            Vector3 finalVelocity = forward + strafe + vertical;
            controller.Move(finalVelocity * Time.deltaTime);
        }
        else
        if (efs == 2)
        {
            GC.Camera[0].SetActive(true);
            GC.Camera[1].SetActive(false);

            float forwardInput = Input.GetAxisRaw("Vertical");
            float strafeInput = Input.GetAxisRaw("Horizontal");

            forward = forwardInput * forwardSpeed * transform.forward;
            strafe = strafeInput * strafeSpeed * transform.right;

            vertical += gravity * Time.deltaTime * Vector3.up;

            efs = 0;

            Vector3 finalVelocity = forward + strafe + vertical;
            controller.Move(finalVelocity * Time.deltaTime);
        }
        else
        if (efs == 3)
        {
            float forwardInput = Input.GetAxisRaw("Vertical");
            float strafeInput = Input.GetAxisRaw("Horizontal");

            forward = forwardInput * forwardSpeed * transform.forward;
            strafe = strafeInput * strafeSpeed * transform.right;

            vertical += gravity * Time.deltaTime * Vector3.up;

            Vector3 finalVelocity = forward + strafe + vertical;
            controller.Move(finalVelocity * Time.deltaTime);
            //----------------------------------------------------------------------------------------------------------------------------------------
            GC.Camera[2].SetActive(true);
            GC.Camera[0].SetActive(false);
            GC.Camera[1].SetActive(false);
            GC.Camera[3].SetActive(false);
            GC.Camera[4].SetActive(false);
            if (Input.GetKeyDown(KeyCode.G))
            {
                GC.Puzzle0_Fios[1].SetActive(false);
            }
        }
        else
        if (efs == 4)
        {
            float forwardInput = Input.GetAxisRaw("Vertical");
            float strafeInput = Input.GetAxisRaw("Horizontal");

            forward = forwardInput * forwardSpeed * transform.forward;
            strafe = strafeInput * strafeSpeed * transform.right;

            vertical += gravity * Time.deltaTime * Vector3.up;

            Vector3 finalVelocity = forward + strafe + vertical;
            controller.Move(finalVelocity * Time.deltaTime);
            //----------------------------------------------------------------------------------------------------------------------------------------
            GC.Camera[0].SetActive(true);
            GC.Camera[1].SetActive(false);
            GC.Camera[2].SetActive(false);
            GC.Camera[3].SetActive(false);
            GC.Camera[4].SetActive(false);
            efs = 0;
        }
        else
        if (efs == 5)
        {
            float forwardInput = Input.GetAxisRaw("Vertical");
            float strafeInput = Input.GetAxisRaw("Horizontal");

            forward = forwardInput * forwardSpeed * transform.forward;
            strafe = strafeInput * strafeSpeed * transform.right;

            vertical += gravity * Time.deltaTime * Vector3.up;

            Vector3 finalVelocity = forward + strafe + vertical;
            controller.Move(finalVelocity * Time.deltaTime);
            //----------------------------------------------------------------------------------------------------------------------------------------
            GC.Camera[4].SetActive(true);
            GC.Camera[0].SetActive(false);
            GC.Camera[1].SetActive(false);
            GC.Camera[3].SetActive(false);
            GC.Camera[2].SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.F))
        {
            efs += 1;
        }
        #endregion
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
   
