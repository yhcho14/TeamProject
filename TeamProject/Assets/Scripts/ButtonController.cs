using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private GameObject ButtonTop;
    [SerializeField] private GameObject Wall;
    [SerializeField] private LayerMask WhatIsButton;
    [SerializeField] private Transform feetPos;
    [SerializeField] private float checkRadius;
    [SerializeField] private float ButtonDepth;


    private bool isTouched;
    private bool isButtonTop;

    void Start()
    {
        isButtonTop = true;
    }

    void Update()
    {
        isTouched = Physics2D.OverlapCircle(feetPos.position, checkRadius, WhatIsButton);

        if(isTouched && (isButtonTop == true))
        {
            ButtonTop.transform.Translate(0, -(ButtonDepth), 0);
            isButtonTop = false;
            //버튼 눌림
        }
        else if((!isTouched) && (isButtonTop == false))
        {
            ButtonTop.transform.Translate(0, ButtonDepth, 0);
            isButtonTop = true;
        }

        if(isButtonTop == false)
        {
            if(Wall.transform.position.y > -10)
                Wall.transform.Translate(0, -0.1f, 0);
        }
        else
        {
            if (Wall.transform.position.y < 0)
                Wall.transform.Translate(0, 0.2f, 0);
        }
    }
}
