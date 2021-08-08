using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;  // Animator 타입의 변수

    private void Awake()
    {
        animator = GetComponent<Animator>();    // 컴포넌트 가져오기
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))    // 스페이스바 입력 시
        {
            animator.SetTrigger("isDie");   // isDie 트리거 활성화
        }    
    }

    public void OnDieEvent()
    {
        Debug.Log("End of Die Animation");
    }
}
