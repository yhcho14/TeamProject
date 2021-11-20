using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private Camera camera;
    [SerializeField] private GameObject cameraObj;


    // Update is called once per frame
    void Update()
    {
        camera = Camera.main;
        if(GameObject.Find("Camera2"))
            cameraObj = GameObject.Find("Camera2");
        else
            cameraObj = GameObject.Find("Camera1");
        float f = Player.transform.position.x;
        Vector3 v = cameraObj.transform.position;
        v.x = f;
        cameraObj.transform.position = v;
    }
}
