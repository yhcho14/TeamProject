using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToStartScript : MonoBehaviour
{
    [SerializeField] GameObject Start;
    [SerializeField] GameObject SelectMode;
    [SerializeField] GameObject SelectWorld;
    [SerializeField] GameObject WorldOne;
    [SerializeField] GameObject WorldTwo;
    [SerializeField] GameObject ReturnButton;

    public void PressReturnButton()
    {
        SelectMode.SetActive(false);
        SelectWorld.SetActive(false);
        WorldOne.SetActive(false);
        WorldTwo.SetActive(false);
        ReturnButton.SetActive(false);
        Start.SetActive(true);
    }
}
