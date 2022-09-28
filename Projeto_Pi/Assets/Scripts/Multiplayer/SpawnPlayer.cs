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
    private PhotonView pv;

    private int idPLayer;
    //----------------------------------------------------------------------------------------------------------------------------------------
    private void Start()
    {
        if (idPLayer == 0)
        {
            Vector3 r = new Vector3(Random.Range(MinX, MinY), Random.Range(MinY, MaxY), Random.Range(MinZ, MaxZ));
            PhotonNetwork.Instantiate(PlayerPrefabs1.name, r, Quaternion.identity);
            idPLayer++;
        }

        if (pv.ViewID == 1002)
        {
            Vector3 m = new Vector3(Random.Range(MinX, MinY), Random.Range(MinY, MaxY), Random.Range(MinZ, MaxZ));
            PhotonNetwork.Instantiate(PlayerPrefabs2.name, m, Quaternion.identity);
            PhotonNetwork.Instantiate(PlayerPrefabs2.name, spawnPosition.transform.position, Quaternion.identity,0);

        }
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
