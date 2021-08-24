using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f; // 속도   
    [SerializeField]
    private float jumpForce = 8.0f; // 점프 힘 (클수록 높이 점프한다)
    [SerializeField]
    private float gs = 1.5f;
    private Rigidbody2D rigid2D;

    [SerializeField]
    private LayerMask groundLayer;  // 바닥 체크를 위한 충돌 레이어
    private CapsuleCollider2D capsuleCollider2D; // 오브젝트의 충돌 범위 컴포넌트
    private bool isGrounded;    // 바닥에 닿아있을 때 true이다
    private Vector3 footPosition;   // 발의 위치


    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();  // Rigidbody2D의 컴포넌트를 가진다.
        capsuleCollider2D = GetComponent<CapsuleCollider2D>();  // CapsuleCollider2D의 컴포넌트를 가진다.
    }
    private void FixedUpdate()
    {
        // 플레이어 오브젝트의 Collider2D min, center, max 위치 정보
        Bounds bounds = capsuleCollider2D.bounds;
        // 플레이어 발 위치 설정
        footPosition = new Vector2(bounds.center.x, bounds.min.y);
        // 발 위치에 원 생성, 원이 바닥과 닿아있으면 true
        isGrounded = Physics2D.OverlapCircle(footPosition, 0.1f, groundLayer);


        rigid2D.gravityScale = gs;    // 점프 높이 조절
    }

    public void Move(float x)   // 좌우 이동
    {
        // x 축 이동은  x * speed, y 축은 기존의 속력 값
        rigid2D.velocity = new Vector2(x * speed, rigid2D.velocity.y);
    }
    public void Jump()  // 점프
    {
        if(isGrounded == true)
        {
            // fumpForce의 크기만큼 위 방향으로 속력 설정
            rigid2D.velocity = Vector2.up * jumpForce;
        }
    }
}
