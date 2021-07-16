using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    private float moveSpeed = 5.0f; // �̵� �ӵ�    
    private Rigidbody2D rigid2D;

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();  //  ���ӿ�����Ʈ�� ������Ʈ(Rigidbody2D)�� ����
    }
    private void Update()
    {
        // Negative left, a : -1
        // Positive right, d : 1
        // Non : 0
        float x = Input.GetAxisRaw("Horizontal");   // �¿�
        // Negative down, s : -1
        // Positive up, w : 1
        // Non : 0
        float y = Input.GetAxisRaw("Vertical");     // ����
        rigid2D.velocity = new Vector3(x, y, 0) * moveSpeed;
    }    
}