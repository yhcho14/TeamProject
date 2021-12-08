using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleKeyController : MonoBehaviour
{
    [SerializeField] GameObject Key;
    [SerializeField] GameObject Door;

    private void Start()
    {
        //Player.gameObject.GetComponent<Renderer>().material.color = Color.red;
        Door.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            //Player.gameObject.GetComponent<Renderer>().material.color = Color.green;
            Door.gameObject.GetComponent<Renderer>().material.color = Color.yellow;

            Key.SetActive(false);
        }
    }

}
