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

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");   // 좌 우 입력
        movement2D.Move(x); // 입력받은 float x로 이동방향 제어

        // 스페이스 키를 누르면 점프
        if (Input.GetKeyDown(KeyCode.Space))
        {
            movement2D.Jump();
        }
    }
}
