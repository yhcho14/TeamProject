using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

}
