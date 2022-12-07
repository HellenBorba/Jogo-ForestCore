using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.Animations;
[RequireComponent(typeof(CharacterController))]

public class Player : MonoBehaviour
{
    public GameObject SenhaPuzzle0;
    public int efs, efs2;
    public Animator amin1;
    CharacterController controller;

    private GameContoller GC;
    private ItemCollect IC;
    private Vector3 forward, strafe, vertical;
    private float forwardSpeed = 3, strafeSpeed = 5, gravity, jumpSpeed, maxJumpHeight = 2, timeToMaxHeight = 0.5f, minZ, minX, minY, maxY, maxX, maxZ;
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        IC = GameObject.Find("Glicose").GetComponent<ItemCollect>();
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
        #region F
        #region Movimentação da câmera padrão
        if (efs == 0) //Movimentação da câmera padrão
        {
            float forwardInput = Input.GetAxisRaw("Vertical");
            float strafeInput = Input.GetAxisRaw("Horizontal");

            forward = forwardInput * forwardSpeed * transform.forward;
            strafe = strafeInput * strafeSpeed * transform.right;

            vertical += gravity * Time.deltaTime * Vector3.up;

            Vector3 finalVelocity = forward + strafe + vertical;
            controller.Move(finalVelocity * Time.deltaTime);
        }

        if (efs == 1) //Movimentação da câmera padrão
        {
            transform.eulerAngles = new Vector3(0, -180, 0);

            float forwardInput = Input.GetAxisRaw("Vertical");
            float strafeInput = Input.GetAxisRaw("Horizontal");

            forward = forwardInput * forwardSpeed * transform.forward;
            strafe = strafeInput * strafeSpeed * transform.right;

            vertical += gravity * Time.deltaTime * Vector3.up;

            Vector3 finalVelocity = forward + strafe + vertical;
            controller.Move(finalVelocity * Time.deltaTime);
        }
        else
        if (efs == 2) //Movimentação da câmera padrão
        {
            transform.eulerAngles = new Vector3(0, 0, 0);

            float forwardInput = Input.GetAxisRaw("Vertical");
            float strafeInput = Input.GetAxisRaw("Horizontal");

            forward = forwardInput * forwardSpeed * transform.forward;
            strafe = strafeInput * strafeSpeed * transform.right;

            vertical += gravity * Time.deltaTime * Vector3.up;

            Vector3 finalVelocity = forward + strafe + vertical;
            controller.Move(finalVelocity * Time.deltaTime);

            efs = 0;
        }
        #endregion
        #region Puzzle2
        if (efs2 == 1) //Puzzle2
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
            if (Input.GetKeyDown(KeyCode.G))
            {
                GC.Puzzle0_Fios[1].SetActive(false);
            }
            Cursor.visible = true;
            gameObject.transform.position = GC.SpawnPlayerAqui.transform.position;
        }
        #endregion
        #region Puzzle0
        if (efs == 5) //Puzzle0
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
            GC.Camera[1].SetActive(false);
            GC.Camera[0].SetActive(false);
            Cursor.visible = true;
            gameObject.transform.position = GC.SpawnPlayerAqui.transform.position;
        }
        #endregion
        if(Input.GetKeyDown(KeyCode.F))
        {
            efs += 1;
        }
        #endregion
        //----------------------------------------------------------------------------------------------------------------------------------------
        if (controller.velocity.x != 0 || controller.velocity.z != 0)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                amin1.SetFloat("Andar", 1);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                amin1.SetFloat("Esquerda", 1);
            }
            if(Input.GetKeyDown(KeyCode.D))
            {
                amin1.SetFloat("Direita", 1);
            }
        }
        else
        {
            amin1.SetFloat("Andar", 0);
            amin1.SetFloat("Esquerda", 0);
            amin1.SetFloat("Direita", 0);
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
   
