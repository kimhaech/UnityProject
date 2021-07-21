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
    private Vector3 lastMoveDirection = Vector3.right;  // 마지막에 움직였던 방향, 최초에는 오른쪽으로 이동하도록 한다

    // Update is called once per frame
    void Update()
    {
        // 플레이어 오브젝트 이동
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        transform.position += new Vector3(x, y, 0) * moveSpeed * Time.deltaTime;

        // 방향키를 누른 경우
        if (x != 0 || y != 0)
        {
            lastMoveDirection = new Vector3(x, y, 0);
        }

        // bullet 발사
        if (Input.GetKeyDown(keyCodeFire))  // 버튼을 누르면 실행
        {
            // clone을 생성 -> bulletPrefab을 생성, 현재 오브젝트의 위치
            GameObject clone = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

            clone.name = "Bullet";
            clone.transform.localScale = Vector3.one * 0.5f;
            clone.GetComponent<SpriteRenderer>().color = Color.red;

            clone.GetComponent<Movement2D>().Setup(lastMoveDirection);  // 저장한 방향을 Movement2D의 Setup()이라는 함수에 방향값을 전달
        }
    }
}
