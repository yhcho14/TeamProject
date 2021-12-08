using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;

public class MultiPausePanelScript : MonoBehaviour
{
    [SerializeField] GameObject PausePanel;

    public void PressResumeButton()
    {
        Time.timeScale = 1f;
        PausePanel.SetActive(false);
    }
    public void PressQuitButton()
    {
        PhotonNetwork.LeaveRoom();
        PhotonNetwork.LeaveLobby();
        PhotonNetwork.Disconnect();
        SceneManager.LoadScene("StartScene");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PausePanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
