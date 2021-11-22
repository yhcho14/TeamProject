using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectWorldScript : MonoBehaviour
{
    [SerializeField] GameObject SelectWorld;
    [SerializeField] GameObject World1;
    [SerializeField] GameObject World2;

    public void PressWorldOne()
    {
        SelectWorld.SetActive(false);
        World1.SetActive(true);
    }
    public void PressWorldTwo()
    {
        SelectWorld.SetActive(false);
        World2.SetActive(true);
    }
}
