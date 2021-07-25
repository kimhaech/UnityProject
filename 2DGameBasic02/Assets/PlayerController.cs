using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Movement2D movement2D;

    private void Awake()
    {
        movement2D = GetComponent<Movement2D>();
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");   // 좌우 입력
        movement2D.Move(x); // 이동 방향 제어

        // 스페이스 키를 누르면 점프
        if (Input.GetKeyDown(KeyCode.Space))
        {
            movement2D.Jump();
        }
        // 스페이스 키를 누르고 있으면 isLongJump = true
        if (Input.GetKey(KeyCode.Space))
        {
            movement2D.isLongJump = true;
        }
        // 스페이스 키를 떼면 false
        if (Input.GetKeyUp(KeyCode.Space))
        {
            movement2D.isLongJump = false;
        }
    }
}
