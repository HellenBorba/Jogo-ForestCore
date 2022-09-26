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
        Vector3 r = new Vector3(Random.Range(MinX, MinY), Random.Range(MinY, MaxY), Random.Range(MinZ, MaxZ));
        PhotonNetwork.Instantiate(PlayerPrefabs.name, r ,Quaternion.identity); 
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
