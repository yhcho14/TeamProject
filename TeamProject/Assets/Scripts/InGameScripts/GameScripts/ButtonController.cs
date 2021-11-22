using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private GameObject ButtonTop;
    [SerializeField] private GameObject Wall;
    [SerializeField] private LayerMask WhatIsButton;
    [SerializeField] private GameObject feetPos1;
    [SerializeField] private GameObject feetPos2;
    [SerializeField] private float checkRadius;
    [SerializeField] private float ButtonDepth;
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject LocalPlayer;

    private bool isTouched1;
    private bool isTouched2;
    private bool isButtonTop;

    void Start()
    {
        isButtonTop = true;
    }

    void Update()
    {
        Player = GameObject.FindWithTag("Player");
        LocalPlayer = GameObject.FindWithTag("LocalPlayer");
        feetPos1 = GameObject.FindWithTag("FeetPos1");
        feetPos2 = GameObject.FindWithTag("FeetPos2");
        //isTouched1 = Physics2D.OverlapCircle(feetPos1.transform.position, checkRadius, WhatIsButton);
        //isTouched2 = Physics2D.OverlapCircle(feetPos2.transform.position, checkRadius, WhatIsButton);

        if ((isTouched1 || isTouched2) && (isButtonTop == true))
        {
            ButtonTop.transform.Translate(0, -(ButtonDepth), 0);
            isButtonTop = false;
            //버튼 눌림
        }
        else if((!(isTouched1 || isTouched2)) && (isButtonTop == false))
        {
            ButtonTop.transform.Translate(0, ButtonDepth, 0);
            isButtonTop = true;
        }

        if(isButtonTop == false)
        {
            if(Wall.transform.position.y > -10)
                Wall.transform.Translate(0, -0.25f, 0);
        }
        else
        {
            if (Wall.transform.position.y < 0)
                Wall.transform.Translate(0, 0.25f, 0);
        }
    }
}
