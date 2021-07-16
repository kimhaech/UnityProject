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
        // �ӵ� ����
        moveSpeed = 5.0f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // ���� ������Ʈ�� ���� �������� ���� 
        moveObject.GetComponent<SpriteRenderer>().color = Color.black;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        // ��ġ �̵�
        moveObject.transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        // trigger����� �Ͼ�� ����
        moveObject.GetComponent<SpriteRenderer>().color = Color.white;
        // ������Ʈ�� ��ġ�� (0,3,0)���� ����
        moveObject.transform.position = new Vector3(0, 3, 0);
    }
}
