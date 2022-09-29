using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject PlayerPrefabs1, PlayerPrefabs2;
    public GameObject Spawn;
    public GameObject spawnPosition;
    public float MaxX, MaxY, MaxZ, MinX, MinY, MinZ;
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void Start()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.NickName = ("Player1");
            Vector3 r = new Vector3(Random.Range(MinX, MinY), Random.Range(MinY, MaxY), Random.Range(MinZ, MaxZ));
            PhotonNetwork.Instantiate(PlayerPrefabs1.name, r, Quaternion.identity);
        }
        else
        {
            PhotonNetwork.NickName = ("Player2");
            Vector3 m = new Vector3(Random.Range(MinX, MinY), Random.Range(MinY, MaxY), Random.Range(MinZ, MaxZ));
            PhotonNetwork.Instantiate(PlayerPrefabs2.name, m, Quaternion.identity);
        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
