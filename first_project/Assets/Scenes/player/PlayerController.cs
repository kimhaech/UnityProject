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
        float x = Input.GetAxisRaw("Horizontal");   // �� �� �Է�
        movement2D.Move(x); // �Է¹��� float x�� �̵����� ����

        // �����̽� Ű�� ������ ����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            movement2D.Jump();
        }
    }
}
