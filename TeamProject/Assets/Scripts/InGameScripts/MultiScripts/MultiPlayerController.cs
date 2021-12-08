using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class MultiPlayerController : MonoBehaviourPun
{
    private Rigidbody2D rb; //  플레이어 객체
    private Animator anim;

    public float speed;  // 속도
    public float jumpForce;  // 점프 높이 
    public float moveInput;  // 좌우 정도

    public bool isGrounded;  // 땅에 닿아 있는지
    public Transform feetPos;  // 플레이어 발의 위치
    public float checkRadius;  // 원의 반지름
    public LayerMask whatIsGround;  // 유니티 엔진 땅 레이어

    public float jumpTimeCounter;  // 점프 시간 측정
    public float jumpTime; // 점프 길이
    public bool isJumping; // 점프 중인지 아닌지 체크

    private void Start()  // 시작 시 호출
    {
        Application.targetFrameRate = 60;
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody2D>(); // 유니티 엔진에서 스크립트가 달려 있는 오브젝트의 Rigidbody2D를 rb 변수에 연결


        anim = this.GetComponent<Animator>();

    }

    private void FixedUpdate()  // 물리엔진 호출을 위한 Update
    {
        moveInput = Input.GetAxisRaw("Horizontal"); // 일정 주기로 moveInput에 좌우 입력 값을 실수로 입력

        if (photonView.IsMine)
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);  // 입력받은 입력 값을 토대로 좌우 이동
    }

    private void Update()  // 매 프레임마다 호출
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround); // 플레이어의 발과 땅이 닿았는지 체크

        if (photonView.IsMine)
        {
            if (moveInput > 0)  // 플레이어 방향 전환
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
            else if (moveInput < 0)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
            }

            if (isGrounded == true && Input.GetKeyDown(KeyCode.Space) && isJumping == false) // 점프 실행
            {
                isJumping = true;
                jumpTimeCounter = jumpTime;
                rb.velocity = Vector2.up * jumpForce;
            }

            if (Input.GetKey(KeyCode.Space) && isJumping == true) // 점프 도중에 점프 키를 눌렀을 때 더블점프 방지
            {
                if (jumpTimeCounter > 0)
                {
                    rb.velocity = Vector2.up * jumpForce;
                    jumpTimeCounter -= Time.deltaTime;
                }
                else
                {
                    isJumping = false;
                }
            }

            if (Input.GetKeyUp(KeyCode.Space)) // 점프 종료
            {
                isJumping = false;
            }
        }

        if (photonView.IsMine)
            anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));

    }
}
