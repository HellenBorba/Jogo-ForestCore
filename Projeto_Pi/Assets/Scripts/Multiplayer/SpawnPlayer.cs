using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject PlayerPrefabs;
    public GameObject Spawn;
    public float MaxX, MaxY, MaxZ, MinX, MinY, MinZ;
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void Start()
    {
        PhotonNetwork.Instantiate(PlayerPrefabs.name, Spawn.transform.position,Quaternion.identity, 0);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
