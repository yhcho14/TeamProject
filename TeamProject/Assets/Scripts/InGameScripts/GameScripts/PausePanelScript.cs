using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanelScript : MonoBehaviour
{
    [SerializeField] GameObject PausePanel;

    public void PressResumeButton()
    {
        Time.timeScale = 1f;
        PausePanel.SetActive(false);
    }
    public void PressQuitButton()
    {
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
