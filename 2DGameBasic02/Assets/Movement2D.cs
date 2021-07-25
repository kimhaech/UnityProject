using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f; // 이동 속도
    [SerializeField]
    private float jumpForce = 8.0f; // 점프 힘 (클수록 높이 점프한다)
    private Rigidbody2D rigid2D;
    [HideInInspector]   // public 타입 변수를 Inspector view에서 보이지 않게 한다.
    public bool isLongJump = false; // 낮은 점프, 높은 점프를 체크

    [SerializeField]
    private LayerMask groundLayer;  // 바닥 체크를 위한 충돌 레이어
    private CapsuleCollider2D capsuleCollider2D; // 오브젝트의 충돌 범위 컴포넌트
    private bool isGrounded;    // 바닥에 닿아있을 때 true이다
    private Vector3 footPosition;   // 발의 위치

    [SerializeField]
    private int maxJumpCount = 2;   // 땅을 밟기 전까지의 최대 점프 횟수
    private int currentJumpCount = 0;   // 현재 가능한 점프 횟수
    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        capsuleCollider2D = GetComponent<CapsuleCollider2D>();
    }

    private void FixedUpdate()
    {
        // 플레이어 오브젝트의 Collider2D min, center, max 위치 정보
        Bounds bounds = capsuleCollider2D.bounds;
        // 플레이어 발 위치 설정
        footPosition = new Vector2(bounds.center.x, bounds.min.y);
        // 발 위치에 원 생성, 원이 바닥과 닿아있으면 true
        isGrounded = Physics2D.OverlapCircle(footPosition, 0.1f, groundLayer);

        // 플레이어가 바닥에 닿아있고 y축 속도가 0 이하
        // y축 속도가 0 이하라는 조건을 추가하지 않을 시 점프키를 누르는 순간에도 초기화가 된다
        if (isGrounded == true && rigid2D.velocity.y <= 0)
        {
            currentJumpCount = maxJumpCount;
        }

        // 낮은 점프, 높은 점프 구현을 위한 중력 계수 (gravityScale) 조절
        if (isLongJump && rigid2D.velocity.y > 0)   //  높은 점프 -> 중력 계수가 낮다
        {
            rigid2D.gravityScale = 1.0f;
        }
        else // 낮은 점프
        {
            rigid2D.gravityScale = 2.5f;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;  // 파란색으로 설정
        Gizmos.DrawSphere(footPosition, 0.1f);  // 발의 위치에 0.1 반지름의 구 생성
    }
    public void Move(float x)
    {
        // x 축 이동은  x * speed, y 축은 기존의 속력 값
        rigid2D.velocity = new Vector2(x * speed, rigid2D.velocity.y);
    }

    public void Jump()
    {
        if (currentJumpCount > 0) // 남은 점프 횟수가 0 보다 클 때
        {
            // jumpForce의 크기만큼 위 방향으로 속력 설정
            rigid2D.velocity = Vector2.up * jumpForce;
            // 점프횟수 1회 감소
            currentJumpCount--;
        }
    }
}
