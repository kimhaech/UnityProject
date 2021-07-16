using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    [SerializeField]
    private GameObject moveObject;
    [SerializeField]
    private Vector3 moveDirection;
    private float moveSpeed;

    private void Awake()
    {
        // 속도 설정
        moveSpeed = 5.0f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 게임 오브젝트의 색을 검정으로 변경 
        moveObject.GetComponent<SpriteRenderer>().color = Color.black;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        // 위치 이동
        moveObject.transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        // trigger종료시 하얀색 변경
        moveObject.GetComponent<SpriteRenderer>().color = Color.white;
        // 오브젝트의 위치를 (0,3,0)으로 설정
        moveObject.transform.position = new Vector3(0, 3, 0);
    }
}
