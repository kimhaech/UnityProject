using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    [SerializeField]
    private float speed = 1.0f; // �ӵ�   
    [SerializeField]
    private float jumpForce = 8.0f; // ���� �� (Ŭ���� ���� �����Ѵ�)
    [SerializeField]
    private float gs = 1.5f;
    private Rigidbody2D rigid2D;

    [SerializeField]
    private LayerMask groundLayer;  // �ٴ� üũ�� ���� �浹 ���̾�
    private BoxCollider2D BoxCollider2D; // ������Ʈ�� �浹 ���� ������Ʈ
    private bool isGrounded;    // �ٴڿ� ������� �� true�̴�
    private Vector3 footPosition;   // ���� ��ġ


    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();  // Rigidbody2D�� ������Ʈ�� ������.
        BoxCollider2D = GetComponent<BoxCollider2D>();  // CapsuleCollider2D�� ������Ʈ�� ������.
    }
    private void FixedUpdate()
    {
        // �÷��̾� ������Ʈ�� Collider2D min, center, max ��ġ ����
        Bounds bounds = BoxCollider2D.bounds;
        // �÷��̾� �� ��ġ ����
        footPosition = new Vector2(bounds.center.x, bounds.min.y);
        // �� ��ġ�� �� ����, ���� �ٴڰ� ��������� true
        isGrounded = Physics2D.OverlapCircle(footPosition, 0.1f, groundLayer);


        rigid2D.gravityScale = gs;    // ���� ���� ����
    }

    public void Move(float x)   // �¿� �̵�
    {
        // x �� �̵���  x * speed, y ���� ������ �ӷ� ��
        rigid2D.velocity = new Vector2(x * speed, rigid2D.velocity.y);
    }
    public void Jump()  // ����
    {
        if(isGrounded == true)
        {
            // fumpForce�� ũ�⸸ŭ �� �������� �ӷ� ����
            rigid2D.velocity = Vector2.up * jumpForce;
        }
    }
}
