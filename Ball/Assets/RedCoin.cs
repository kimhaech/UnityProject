using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCoin : MonoBehaviour
{
    void OnTriggerEnter(Collider col)  // trigger 시
    {
        if (col.gameObject.name == "Ball")
        {
            DestroyObstacles(); // 장애물을 파괴하는 함수 호출
            Destroy(gameObject); // 스크립트가 추가되어있는 게임 오브젝트를 뜻한다.
        }
    }

    void DestroyObstacles()
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        for(int i = 0; i<obstacles.Length; i++)
        {
            Destroy(obstacles[i]);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
