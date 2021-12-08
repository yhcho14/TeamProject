using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiButtonController : MonoBehaviour
{
    [SerializeField] private GameObject ButtonTop;
    [SerializeField] private GameObject Wall;
    [SerializeField] private LayerMask WhatIsButton;
    [SerializeField] private float checkRadius;
    [SerializeField] private float ButtonDepth;
    [SerializeField] private GameObject[] feetPos1;

    private bool isTouched1;
    private bool isTouched2;
    private bool isButtonTop;

    void Start()
    {
        isButtonTop = true;
    }

    void Update()
    {
        feetPos1 = GameObject.FindGameObjectsWithTag("FeetPos1");


        isTouched1 = Physics2D.OverlapCircle(feetPos1[0].transform.position, checkRadius, WhatIsButton);
        isTouched2 = Physics2D.OverlapCircle(feetPos1[1].transform.position, checkRadius, WhatIsButton);

        if ((isTouched1||isTouched2) && (isButtonTop == true))
        {
            ButtonTop.transform.Translate(0, -(ButtonDepth), 0);
            isButtonTop = false;
            //��ư ����
        }
        else if ((!(isTouched1||isTouched2)) && (isButtonTop == false))
        {
            ButtonTop.transform.Translate(0, ButtonDepth, 0);
            isButtonTop = true;
        }

        if (isButtonTop == false)
        {
            if (Wall.transform.position.y > -10)
                Wall.transform.Translate(0, -0.925f, 0);
        }
        else
        {
            if (Wall.transform.position.y < 0)
                Wall.transform.Translate(0, 0.925f, 0);
        }
    }
}
