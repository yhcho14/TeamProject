using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    [SerializeField] GameObject Start;
    [SerializeField] GameObject SelectMode;
    [SerializeField] GameObject ReturnButton;


    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            Start.SetActive(false);
            SelectMode.SetActive(true);
            ReturnButton.SetActive(true);
        }
    }
}
