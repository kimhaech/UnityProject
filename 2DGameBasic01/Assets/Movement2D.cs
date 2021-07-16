using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    private float moveSpeed = 5.0f; // 이동 속도    
    private Rigidbody2D rigid2D;

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();  //  게임오브젝트의 컴포넌트(Rigidbody2D)에 접근
    }
    private void Update()
    {
        // Negative left, a : -1
        // Positive right, d : 1
        // Non : 0
        float x = Input.GetAxisRaw("Horizontal");   // 좌우
        // Negative down, s : -1
        // Positive up, w : 1
        // Non : 0
        float y = Input.GetAxisRaw("Vertical");     // 상하
        rigid2D.velocity = new Vector3(x, y, 0) * moveSpeed;
    }    
}