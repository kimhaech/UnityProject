using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private Movement2D movement2D;
    private Animator animator;  // Animator Ÿ���� ����
    private string stance = "stand";
    private void Awake()
    {
        //movement2D = GetComponent<Movement2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       // float x = Input.GetAxisRaw("Horizontal");   // �� �� �Է�
       /* movement2D.Move(x); // �Է¹��� float x�� �̵����� ����*/
        

        // �����̽� Ű�� ������ ����
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            movement2D.Jump();
        }
*/
        if (Input.GetKeyDown(KeyCode.C) && stance == "stand")   // C �Է� and ���� stand => �ɱ�
        {
            animator.SetTrigger("sit");
            stance = "sit";
        }
        else if (Input.GetKeyDown(KeyCode.C) && stance=="sit") // C �Է� and ���� sit => �Ͼ��
        {
            animator.SetTrigger("stand");
            stance = "stand";
        }
    }
}
