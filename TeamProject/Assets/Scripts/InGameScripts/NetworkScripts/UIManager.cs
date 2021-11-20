using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public GameObject startMenu;
    public InputField usernameField;
    public InputField IPField;
    public InputField PortField;
    public GameObject map;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Debug.Log("Instance already exists, destroying object!");
            Destroy(this);
        }
    }

    public void ConnectToServer()
    {
        //Client.instance.ip = IPField.text;
        //Client.instance.port = int.Parse(PortField.text);
        startMenu.SetActive(false);
        usernameField.interactable = false;
        map.SetActive(true);
        Client.instance.ConnectToServer();
    }    
}
