using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D Player;

    Vector2 Vector;

    void MoveByInput()
    {
        Vector2 Velocity = Vector2.zero;

        if(Input.GetAxisRaw("Horizontal") < 0)
        {
            Velocity = new Vector2(-2f, 0);
            Player.AddForce(Velocity);
        }

        if(Input.GetAxisRaw("Horizontal") > 0)
        {
            Velocity = new Vector2(2f, 0);
            Player.AddForce(Velocity);
        }

        if(Input.GetButtonDown("Jump"))
        {
            Velocity = new Vector2(0, 5f);
            Player.AddForce(Velocity, ForceMode2D.Impulse);
        }       
    }

    // Update is called once per frame
    void Update()
    {
        MoveByInput();
    }
}
