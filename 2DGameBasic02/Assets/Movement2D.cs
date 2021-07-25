using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f; // �̵� �ӵ�
    [SerializeField]
    private float jumpForce = 8.0f; // ���� �� (Ŭ���� ���� �����Ѵ�)
    private Rigidbody2D rigid2D;
    [HideInInspector]   // public Ÿ�� ������ Inspector view���� ������ �ʰ� �Ѵ�.
    public bool isLongJump = false; // ���� ����, ���� ������ üũ

    [SerializeField]
    private LayerMask groundLayer;  // �ٴ� üũ�� ���� �浹 ���̾�
    private CapsuleCollider2D capsuleCollider2D; // ������Ʈ�� �浹 ���� ������Ʈ
    private bool isGrounded;    // �ٴڿ� ������� �� true�̴�
    private Vector3 footPosition;   // ���� ��ġ

    [SerializeField]
    private int maxJumpCount = 2;   // ���� ��� �������� �ִ� ���� Ƚ��
    private int currentJumpCount = 0;   // ���� ������ ���� Ƚ��
    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        capsuleCollider2D = GetComponent<CapsuleCollider2D>();
    }

    private void FixedUpdate()
    {
        // �÷��̾� ������Ʈ�� Collider2D min, center, max ��ġ ����
        Bounds bounds = capsuleCollider2D.bounds;
        // �÷��̾� �� ��ġ ����
        footPosition = new Vector2(bounds.center.x, bounds.min.y);
        // �� ��ġ�� �� ����, ���� �ٴڰ� ��������� true
        isGrounded = Physics2D.OverlapCircle(footPosition, 0.1f, groundLayer);

        // �÷��̾ �ٴڿ� ����ְ� y�� �ӵ��� 0 ����
        // y�� �ӵ��� 0 ���϶�� ������ �߰����� ���� �� ����Ű�� ������ �������� �ʱ�ȭ�� �ȴ�
        if (isGrounded == true && rigid2D.velocity.y <= 0)
        {
            currentJumpCount = maxJumpCount;
        }

        // ���� ����, ���� ���� ������ ���� �߷� ��� (gravityScale) ����
        if (isLongJump && rigid2D.velocity.y > 0)   //  ���� ���� -> �߷� ����� ����
        {
            rigid2D.gravityScale = 1.0f;
        }
        else // ���� ����
        {
            rigid2D.gravityScale = 2.5f;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;  // �Ķ������� ����
        Gizmos.DrawSphere(footPosition, 0.1f);  // ���� ��ġ�� 0.1 �������� �� ����
    }
    public void Move(float x)
    {
        // x �� �̵���  x * speed, y ���� ������ �ӷ� ��
        rigid2D.velocity = new Vector2(x * speed, rigid2D.velocity.y);
    }

    public void Jump()
    {
        if (currentJumpCount > 0) // ���� ���� Ƚ���� 0 ���� Ŭ ��
        {
            // jumpForce�� ũ�⸸ŭ �� �������� �ӷ� ����
            rigid2D.velocity = Vector2.up * jumpForce;
            // ����Ƚ�� 1ȸ ����
            currentJumpCount--;
        }
    }
}
