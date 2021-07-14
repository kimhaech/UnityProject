using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Ball").transform.position;    // 초기 타겟 위치 -> Ball의 위치
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, 0.1f); // 해당 방향으로 날아가게 한다.
        transform.Rotate(new Vector3(0, 0, 5)); // z축의 방향으로 5도만큼 회전

    }

    void OnTriggerEnter(Collider collider) // 돌과 부딪힌 경우
    {
        if (collider.gameObject.name == "Ball")  // Ball이라는 오브젝트인 경우
        {
            GameManager gmComponent = GameObject.Find("GameManager").GetComponent<GameManager>();
            gmComponent.RestartGame();
        }
    }
}
