using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private GameObject ButtonTop;
    [SerializeField] private float ButtonDepth;
    [SerializeField] private LayerMask WhatisButton;
    [SerializeField] private Transform feetPos;
    [SerializeField] private float checkRadius;

    private bool isTouched;
    private bool isButtonTop;

    void Start()
    {
        isButtonTop = true;
    }

    void Update()
    {
        isTouched = Physics2D.OverlapCircle(feetPos.position, checkRadius, WhatisButton);

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
    }
}
