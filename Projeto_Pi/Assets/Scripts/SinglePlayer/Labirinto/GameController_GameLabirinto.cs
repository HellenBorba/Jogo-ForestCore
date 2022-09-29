using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController_GameLabirinto : MonoBehaviour
{
    public GameObject PlayerL, hidro, oxi, car;
    public int kadu;
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerL"))
        {
            switch (kadu)
            {
                case 1:
                    
                    break;
                case 2:
                    Destroy(hidro);
                    break;
                case 3:
                    Destroy(oxi);
                    break;
                case 4:
                    Destroy(car);
                    break;
            }
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
