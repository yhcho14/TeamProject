using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorldOneScript : MonoBehaviour
{
    public void StageOnePressed()
    {
        SceneManager.LoadScene("SingleStage1-1");
        Time.timeScale = 1f;
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
