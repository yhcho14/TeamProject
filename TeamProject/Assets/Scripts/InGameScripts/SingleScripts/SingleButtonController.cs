using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleButtonController : MonoBehaviour
{
    [SerializeField] private GameObject ButtonTop;
    [SerializeField] private GameObject Wall;
    [SerializeField] private LayerMask WhatIsButton;
    [SerializeField] private float checkRadius;
    [SerializeField] private float ButtonDepth;
    [SerializeField] private GameObject feetPos1;

    private bool isTouched1;
    private bool isButtonTop;

    void Start()
    {
        isButtonTop = true;
    }

    void Update()
    {
        feetPos1 = GameObject.FindGameObjectWithTag("FeetPos1");


        isTouched1 = Physics2D.OverlapCircle(feetPos1.transform.position, checkRadius, WhatIsButton);

        if ((isTouched1) && (isButtonTop == true))
        {
            ButtonTop.transform.Translate(0, -(ButtonDepth), 0);
            isButtonTop = false;
            //��ư ����
        }
        else if ((!(isTouched1)) && (isButtonTop == false))
        {
            ButtonTop.transform.Translate(0, ButtonDepth, 0);
            isButtonTop = true;
        }

        if (isButtonTop == false)
        {
            if (Wall.transform.position.y > -10)
                Wall.transform.Translate(0, -0.025f, 0);
        }
        else
        {
            if (Wall.transform.position.y < 0)
                Wall.transform.Translate(0, 0.025f, 0);
        }
    }
}
