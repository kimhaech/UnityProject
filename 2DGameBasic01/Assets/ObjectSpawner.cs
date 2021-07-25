using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private int objectSpawnCount = 30;  // 생성 할 오브젝트의 개수
    [SerializeField]
    private GameObject[] prefabArray;   // prefab의 배열
    [SerializeField]
    private Transform[] spawnPointArray;    // 위치값을 가진다
    private int currentObjectCount = 0; // 현재까지 생성한 오브젝트 개수
    private float objectSpawnTime = 0.0f;

    private void Update()
    {
<<<<<<< HEAD
/*        for (int i = 0; i < 10; ++i)
        {
            Vector3 position = new Vector3(-4.5f + i, 0, 0);
            Quaternion rotation = Quaternion.Euler(0, 0, i * 10);

            Instantiate(boxPrefab, position, rotation);
        }*/

        for(int y = 0; y < 10; ++y)
        {
            for (int x = 0; x < 10; ++x)
            {
                Vector3 position = new Vector3(-4.5f + x, 4.5f - y, 0);

                Instantiate(boxPrefab, position, Quaternion.identity);
            }
=======

        if(objectSpawnCount < currentObjectCount + 1)   // 최대 생성 개수만큼 생성할 수 있도록
        {
            return;
        }

        // 원하는 시간마다 오브젝트 생성하도록 하는 연산
        objectSpawnTime += Time.deltaTime;  // 실제 초와 동일하게 실행
        
        // 0.5초마다 실행
        if(objectSpawnTime >= 0.5f)
        {
            int prefabIndex = Random.Range(0, prefabArray.Length);
            int spawnIndex = Random.Range(0, spawnPointArray.Length);

            Vector3 position = spawnPointArray[spawnIndex].position;
            GameObject clone = Instantiate(prefabArray[prefabIndex], position, Quaternion.identity);

            // spawnIndex가 1 -> 오브젝트가 왼쪽에 있기 때문에 오른쪽으로 이동
            Vector3 moveDirection = (spawnIndex == 1 ? Vector3.right : Vector3.left);
            clone.GetComponent<Movement2D>().Setup(moveDirection);

            currentObjectCount++;   // 현재 오브젝트 개수 증가
            objectSpawnTime = 0.0f; // 시간 초기화 -> 0.5초를 계산을 위해서
>>>>>>> 05a15e54780749b97d7e192b8415de9abb4b8cc4
        }
    }
}
 