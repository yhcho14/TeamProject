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
    [SerializeField] private GameObject feetPos;

    private bool isTouched;
    private bool isButtonTop;

    void Start()
    {
        isButtonTop = true;
    }

    void Update()
    {
        isTouched = Physics2D.OverlapCircle(feetPos.transform.position, checkRadius, WhatIsButton);

        if ((isTouched) && (isButtonTop == true))
        {
            ButtonTop.transform.Translate(0, -(ButtonDepth), 0);
            isButtonTop = false;
            //��ư ����
        }
        else if ((!(isTouched)) && (isButtonTop == false))
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
