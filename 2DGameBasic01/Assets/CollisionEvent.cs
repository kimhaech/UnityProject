using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEvent : MonoBehaviour
{
    [SerializeField]
    private Color color;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // �浹 �߻��� 1ȸ
    private void OnCollisionEnter2D(Collision2D collision)
    {
        spriteRenderer.color = color;
    }
    // �浹�� �����Ǵ� ���� �� ������ ȣ��
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log(gameObject.name + " : OnCollisionStay2D");
    }
    // �浹 ����� 1ȸ
    private void OnCollisionExit2D(Collision2D collision)
    {
        spriteRenderer.color = Color.white;
    }
}
