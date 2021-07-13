using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void RestartGame()  // 게임을 재시작 하도록
    {
        Application.LoadLevel("Game");  // unity파일을 저장할 때 Game이라는 이름으로 저장했기 때문
    }

    void RedCoinStart()
    {
        DestroyObstacles();  // 장애물 파괴 함수 호출
    }
    void DestroyObstacles()  // 장애물을 파괴하는 함수
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        for (int i = 0; i < obstacles.Length; i++)
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
