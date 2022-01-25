using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Cinemachine;
public class SpawnPlayer : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update

    public GameObject PrefapPlayer;
    public GameObject SpawnPosition;

    public CinemachineVirtualCamera virtualCamera;
    // public CinemachineVirtualCamera virtualCamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("Joined Room");
        GameObject Player = PhotonNetwork.Instantiate(PrefapPlayer.name, SpawnPosition.transform.position, SpawnPosition.transform.rotation);
        virtualCamera.m_Follow = Player.transform;
        virtualCamera.m_LookAt = Player.transform.Find("KartBouncingCapsule").transform;
    }

}
