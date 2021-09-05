using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Movement2D movement2D;
    private Animator animator;  // Animator 타입의 변수
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
            movement2D.Move(-1); // 입력받은 float x로 이동방향 제어
            animator.SetBool("walk_left", true);
        }
        else
        {
            animator.SetBool("walk_left",false);
        }

        // 스페이스 키를 누르면 점프
        if (Input.GetKeyDown(KeyCode.Space))
        {
            movement2D.Jump();
        }

        // 앉기
        if (Input.GetKeyDown(KeyCode.C) && stance == "stand")   // C 입력 and 상태 stand
        {
            animator.SetTrigger("sit");
            stance = "sit";
        }
        // 일어서기
        else if (Input.GetKeyDown(KeyCode.C) && stance=="sit") // C 입력 and 상태 sit
        {
            animator.SetTrigger("stand");
            stance = "stand";
        }
    }
}
