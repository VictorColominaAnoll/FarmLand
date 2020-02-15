using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoManager : Photon.MonoBehaviour
{

    public GameObject player;
    [SerializeField] private GameObject lobbyCamera;

    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings("1.0");
    }

    void OnJoinedLobby()
    {
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions() { maxPlayers = 2 }, TypedLobby.Default);
    }

    void OnJoinedRoom()
    {
        PhotonNetwork.Instantiate("Player", player.transform.position, Quaternion.identity, 0);
        lobbyCamera.SetActive(false);
    }

   
}
