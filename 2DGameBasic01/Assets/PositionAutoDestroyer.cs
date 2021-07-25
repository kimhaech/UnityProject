using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionAutoDestroyer : MonoBehaviour
{
    private Vector2 limitMin = new Vector2(-7.5f, -4.5f);
    private Vector2 limitMax = new Vector2(7.5f, 4.5f);

    private void Update()
    {
        //  범위를 벗어난 경우 삭제
        if (transform.position.x < limitMin.x || transform.position.x > limitMax.x ||
            transform.position.y < limitMin.y || transform.position.y > limitMax.y)
        {
            // 본인이 소속된 게임 오브젝트
            Destroy(gameObject);
        }
    }
}
