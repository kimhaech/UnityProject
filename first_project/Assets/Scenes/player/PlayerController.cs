using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Movement2D movement2D;
    private Animator animator;  // Animator Ÿ���� ����
    private string stance = "stand";
    private void Awake()
    {
        movement2D = GetComponent<Movement2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            movement2D.Move(-1); // �Է¹��� float x�� �̵����� ����
            animator.SetBool("walk_left", true);
        }
        else
        {
            animator.SetBool("walk_left",false);
        }

        // �����̽� Ű�� ������ ����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            movement2D.Jump();
        }

        // �ɱ�
        if (Input.GetKeyDown(KeyCode.C) && stance == "stand")   // C �Է� and ���� stand
        {
            animator.SetTrigger("sit");
            stance = "sit";
        }
        // �Ͼ��
        else if (Input.GetKeyDown(KeyCode.C) && stance=="sit") // C �Է� and ���� sit
        {
            animator.SetTrigger("stand");
            stance = "stand";
        }
    }
}
