using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class Test : MonoBehaviour
{
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        Vector3 vector3 = new Vector3(Random.Range(-2, 2), 0, 0);
        PhotonNetwork.Instantiate("MultiPlayer", vector3, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
