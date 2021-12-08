using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldOneScript : MonoBehaviour
{
    public void StageOnePressed()
    {
        Application.targetFrameRate = 60;
        Time.timeScale = 1f;
        SceneManager.LoadScene("SingleStage1-1");
    }
    public void StageTwoPressed()
    {

    }
    public void StageThreePressed()
    {

    }
    public void StageFourPressed()
    {

    }
}
