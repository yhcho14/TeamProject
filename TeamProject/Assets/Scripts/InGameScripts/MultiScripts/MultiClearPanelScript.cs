using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;


public class MultiClearPanelScript : MonoBehaviour
{
    [SerializeField] GameObject ClearPanel;

    public void PressContinueButton()
    {
        // next stage
    }

    public void PressQuitButton()
    {
        PhotonNetwork.LeaveRoom();
        PhotonNetwork.LeaveLobby();
        PhotonNetwork.Disconnect();
        SceneManager.LoadScene("StartScene");
    }
}
