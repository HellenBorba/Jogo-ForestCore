using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreatJoin : MonoBehaviourPunCallbacks
{
    public InputField CriarInput;
    public InputField EntrarInput;
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void CriandoSala()
    {
        PhotonNetwork.CreateRoom(CriarInput.text);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public void EntrandoSala()
    {
        PhotonNetwork.JoinRoom(EntrarInput.text);
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("MultiPlayer_Game");
    }
    //----------------------------------------------------------------------------------------------------------------------------------------
    public override void OnMasterClientSwitched(Photon.Realtime.Player newMasterClient)
    {
        base.OnMasterClientSwitched(newMasterClient);
        /* Novo host
        if (PhotonNetwork.LocalPlayer.ActorNumber == newMasterClient.ActorNumber)
        {

        }
        */
    }
}
