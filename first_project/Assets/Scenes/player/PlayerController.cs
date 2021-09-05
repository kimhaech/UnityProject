using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private Movement2D movement2D;
    private Animator animator;  // Animator 타입의 변수
    private string stance = "stand";
    private void Awake()
    {
        //movement2D = GetComponent<Movement2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       // float x = Input.GetAxisRaw("Horizontal");   // 좌 우 입력
       /* movement2D.Move(x); // 입력받은 float x로 이동방향 제어*/
        

        // 스페이스 키를 누르면 점프
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            movement2D.Jump();
        }
*/
        if (Input.GetKeyDown(KeyCode.C) && stance == "stand")   // C 입력 and 상태 stand => 앉기
        {
            animator.SetTrigger("sit");
            stance = "sit";
        }
        else if (Input.GetKeyDown(KeyCode.C) && stance=="sit") // C 입력 and 상태 sit => 일어서기
        {
            animator.SetTrigger("stand");
            stance = "stand";
        }
    }
}
