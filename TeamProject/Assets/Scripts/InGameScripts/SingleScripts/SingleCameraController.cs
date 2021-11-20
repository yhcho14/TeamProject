using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleCameraController : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject camera;


    // Update is called once per frame
    void Update()
    {
        camera = this.gameObject;
        float f = Player.transform.position.x;
        Vector3 v = camera.transform.position;
        v.x = f;
        camera.transform.position = v;
    }
}
