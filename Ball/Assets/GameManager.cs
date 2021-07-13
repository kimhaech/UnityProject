using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void RestartGame()  // ������ ����� �ϵ���
    {
        Application.LoadLevel("Game");  // unity������ ������ �� Game�̶�� �̸����� �����߱� ����
    }

    void RedCoinStart()
    {
        DestroyObstacles();  // ��ֹ� �ı� �Լ� ȣ��
    }
    void DestroyObstacles()  // ��ֹ��� �ı��ϴ� �Լ�
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
