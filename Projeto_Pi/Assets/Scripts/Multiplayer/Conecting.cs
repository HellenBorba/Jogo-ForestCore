using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;

public class Conecting : MonoBehaviourPunCallbacks
{
    //----------------------------------------------------------------------------------------------------------------------------------------
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.AutomaticallySyncScene = true;    
        PhotonNetwork.JoinLobby();
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("Lobby");
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
}
