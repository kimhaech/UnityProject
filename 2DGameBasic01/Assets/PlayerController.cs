using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private KeyCode keyCodeFire = KeyCode.Space;
    [SerializeField]
    private GameObject bulletPrefab;
    private float moveSpeed = 3.0f;
    private Vector3 lastMoveDirection = Vector3.right;  // �������� �������� ����, ���ʿ��� ���������� �̵��ϵ��� �Ѵ�

    // Update is called once per frame
    void Update()
    {
        // �÷��̾� ������Ʈ �̵�
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(x, y, 0) * moveSpeed * Time.deltaTime;

        // ����Ű�� ���� ���
        if (x != 0 || y != 0)
        {
            lastMoveDirection = new Vector3(x, y, 0);
        }

        // bullet �߻�
        if (Input.GetKeyDown(keyCodeFire))  // ��ư�� ������ ����
        {
            // clone�� ���� -> bulletPrefab�� ����, ���� ������Ʈ�� ��ġ
            GameObject clone = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

            clone.name = "Bullet";
            clone.transform.localScale = Vector3.one * 0.5f;
            clone.GetComponent<SpriteRenderer>().color = Color.red;

            clone.GetComponent<Movement2D>().Setup(lastMoveDirection);  // ������ ������ Movement2D�� Setup()�̶�� �Լ��� ���Ⱚ�� ����
        }
    }
}
