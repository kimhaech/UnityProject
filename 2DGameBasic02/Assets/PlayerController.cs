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
        float x = Input.GetAxisRaw("Horizontal");   // �¿� �Է�
        movement2D.Move(x); // �̵� ���� ����

        // �����̽� Ű�� ������ ����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            movement2D.Jump();
        }
        // �����̽� Ű�� ������ ������ isLongJump = true
        if (Input.GetKey(KeyCode.Space))
        {
            movement2D.isLongJump = true;
        }
        // �����̽� Ű�� ���� false
        if (Input.GetKeyUp(KeyCode.Space))
        {
            movement2D.isLongJump = false;
        }
    }
}
