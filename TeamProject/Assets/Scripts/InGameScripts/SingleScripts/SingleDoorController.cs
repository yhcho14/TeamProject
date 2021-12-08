using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleDoorController : MonoBehaviour
{
    [SerializeField] GameObject ClearPanel;
    [SerializeField] GameObject Door;

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        //Debug.Log("/");
        if (Input.GetKey(KeyCode.Space) && Door.gameObject.GetComponent<Renderer>().material.color == Color.yellow)
        {
            //Clear
            Debug.Log(".");
            Time.timeScale = 0;
            ClearPanel.SetActive(true);
        }
    }
}
