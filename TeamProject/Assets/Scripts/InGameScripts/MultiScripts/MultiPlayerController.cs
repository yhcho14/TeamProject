using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class MultiPlayerController : MonoBehaviourPun
{
    private Rigidbody2D rb; //  �÷��̾� ��ü
    private Animator anim;

    public float speed;  // �ӵ�
    public float jumpForce;  // ���� ���� 
    public float moveInput;  // �¿� ����

    public bool isGrounded;  // ���� ��� �ִ���
    public Transform feetPos;  // �÷��̾� ���� ��ġ
    public float checkRadius;  // ���� ������
    public LayerMask whatIsGround;  // ����Ƽ ���� �� ���̾�

    public float jumpTimeCounter;  // ���� �ð� ����
    public float jumpTime; // ���� ����
    public bool isJumping; // ���� ������ �ƴ��� üũ

    private void Start()  // ���� �� ȣ��
    {
        Application.targetFrameRate = 60;
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody2D>(); // ����Ƽ �������� ��ũ��Ʈ�� �޷� �ִ� ������Ʈ�� Rigidbody2D�� rb ������ ����


        anim = this.GetComponent<Animator>();

    }

    private void FixedUpdate()  // �������� ȣ���� ���� Update
    {
        moveInput = Input.GetAxisRaw("Horizontal"); // ���� �ֱ�� moveInput�� �¿� �Է� ���� �Ǽ��� �Է�

        if (photonView.IsMine)
            rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);  // �Է¹��� �Է� ���� ���� �¿� �̵�
    }

    private void Update()  // �� �����Ӹ��� ȣ��
    {
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround); // �÷��̾��� �߰� ���� ��Ҵ��� üũ

        if (photonView.IsMine)
        {
            if (moveInput > 0)  // �÷��̾� ���� ��ȯ
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
            else if (moveInput < 0)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
            }

            if (isGrounded == true && Input.GetKeyDown(KeyCode.Space) && isJumping == false) // ���� ����
            {
                isJumping = true;
                jumpTimeCounter = jumpTime;
                rb.velocity = Vector2.up * jumpForce;
            }

            if (Input.GetKey(KeyCode.Space) && isJumping == true) // ���� ���߿� ���� Ű�� ������ �� �������� ����
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

            if (Input.GetKeyUp(KeyCode.Space)) // ���� ����
            {
                isJumping = false;
            }
        }

        if (photonView.IsMine)
            anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));

    }
}
