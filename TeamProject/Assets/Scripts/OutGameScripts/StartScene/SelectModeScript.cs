using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectModeScript : MonoBehaviour
{
    [SerializeField] GameObject SelectMode;
    [SerializeField] GameObject SelectWorld;

    public void PressSingleplayButton()
    {
        SelectMode.SetActive(false);
        SelectWorld.SetActive(true);
        return;
    }

    public void PressMultiplayButton()
    {
        SelectMode.SetActive(false);
        Application.targetFrameRate = 60;
        Time.timeScale = 1f;
        SceneManager.LoadScene("MultiLobbyScene");
    }
}
