using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class MultiDoorController : MonoBehaviourPunCallbacks
{
    [SerializeField] GameObject ClearPanel;
    [SerializeField] GameObject Door;

    PhotonView pv1;
    PhotonView pv2;

    public GameObject[] Players = new GameObject[2];

    private bool playerClear1 = false;
    private bool playerClear2 = false;

    private void Update()
    {
        Players = GameObject.FindGameObjectsWithTag("Player");

        pv1 = Players[0].GetPhotonView();
        pv2 = Players[1].GetPhotonView();

        if (playerClear1 == true && playerClear2 == true)
        {
            //Clear
            Debug.Log(".");
            Time.timeScale = 0;
            ClearPanel.SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKey(KeyCode.Space) && Door.gameObject.GetComponent<Renderer>().material.color == Color.yellow && other.gameObject == Players[0])
        {
            playerClear1 = true;
        }

        if (Input.GetKey(KeyCode.Space) && Door.gameObject.GetComponent<Renderer>().material.color == Color.yellow && other.gameObject == Players[1])
        {
            playerClear2 = true;
        }
    }
}
