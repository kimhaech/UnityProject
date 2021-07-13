using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCoin : MonoBehaviour
{
    void OnTriggerEnter(Collider col)  // trigger ��
    {
        if (col.gameObject.name == "Ball")
        {
            DestroyObstacles(); // ��ֹ��� �ı��ϴ� �Լ� ȣ��
            Destroy(gameObject); // ��ũ��Ʈ�� �߰��Ǿ��ִ� ���� ������Ʈ�� ���Ѵ�.
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
