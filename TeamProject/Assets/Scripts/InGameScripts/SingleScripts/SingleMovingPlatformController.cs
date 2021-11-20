using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleMovingPlatformController : MonoBehaviour
{
    [SerializeField] GameObject Player;
    GameObject MovingPlatform;
    bool isMoveRight;
    float sx, sy;

    private void Start()
    {
        MovingPlatform = this.gameObject;
        sx = MovingPlatform.transform.position.x;
        sy = MovingPlatform.transform.position.y;
    }

    void Update()
    {
        if(MovingPlatform.transform.position.x < sx + 10 && MovingPlatform.transform.position.x <= sx)
        {
            isMoveRight = true;
        }
        else if(MovingPlatform.transform.position.x > sx && MovingPlatform.transform.position.x >= sx+10)
        {
            isMoveRight = false;
        }

        if (isMoveRight)
        {
            MovingPlatform.transform.Translate(0.025f, 0, 0);
        }
        else if (!isMoveRight)
        {
            MovingPlatform.transform.Translate(-0.025f, 0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}
