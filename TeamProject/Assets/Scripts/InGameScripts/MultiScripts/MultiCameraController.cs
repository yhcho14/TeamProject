using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class MultiCameraController : MonoBehaviourPun
{
    public GameObject[] Players = new GameObject[2];
    private GameObject camera;
    PhotonView pv1;
    PhotonView pv2;

    private void Start()
    {
        camera = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Players = GameObject.FindGameObjectsWithTag("Player");
        pv1 = Players[0].GetPhotonView();
        pv2 = Players[1].GetPhotonView();

        if (pv1.IsMine)
        {
            float f = Players[0].transform.position.x;
            Vector3 v = camera.transform.position;
            v.x = f;
            camera.transform.position = v;
        }
        else if(pv2.IsMine)
        {
            float f = Players[1].transform.position.x;
            Vector3 v = camera.transform.position;
            v.x = f;
            camera.transform.position = v;
        }
    }
}
