using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
public class ConnectToServer : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.SendRate = 20;
        PhotonNetwork.SerializationRate =5;
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("Setting ...");
    }



    public override void OnConnectedToMaster(){
        Debug.Log("Join to Lobby");
        PhotonNetwork.JoinLobby();
    }


    public override void OnJoinedLobby()
    {
        Debug.Log("Creating zoom");
         PhotonNetwork.CreateRoom("zoom1");
    }
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log(message + "Error code: " + returnCode );
         PhotonNetwork.JoinRoom("zoom1");
    }

}
