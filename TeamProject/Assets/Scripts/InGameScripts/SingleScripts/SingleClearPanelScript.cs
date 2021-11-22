using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SingleClearPanelScript : MonoBehaviour
{
    [SerializeField] GameObject ClearPanel;

    public void PressContinueButton()
    {
        // next stage
    }

    public void PressQuitButton()
    {
        SceneManager.LoadScene("StartScene");
    }
}
