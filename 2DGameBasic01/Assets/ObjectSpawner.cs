using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private int objectSpawnCount = 30;  // ���� �� ������Ʈ�� ����
    [SerializeField]
    private GameObject[] prefabArray;   // prefab�� �迭
    [SerializeField]
    private Transform[] spawnPointArray;    // ��ġ���� ������
    private int currentObjectCount = 0; // ������� ������ ������Ʈ ����
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

        if(objectSpawnCount < currentObjectCount + 1)   // �ִ� ���� ������ŭ ������ �� �ֵ���
        {
            return;
        }

        // ���ϴ� �ð����� ������Ʈ �����ϵ��� �ϴ� ����
        objectSpawnTime += Time.deltaTime;  // ���� �ʿ� �����ϰ� ����
        
        // 0.5�ʸ��� ����
        if(objectSpawnTime >= 0.5f)
        {
            int prefabIndex = Random.Range(0, prefabArray.Length);
            int spawnIndex = Random.Range(0, spawnPointArray.Length);

            Vector3 position = spawnPointArray[spawnIndex].position;
            GameObject clone = Instantiate(prefabArray[prefabIndex], position, Quaternion.identity);

            // spawnIndex�� 1 -> ������Ʈ�� ���ʿ� �ֱ� ������ ���������� �̵�
            Vector3 moveDirection = (spawnIndex == 1 ? Vector3.right : Vector3.left);
            clone.GetComponent<Movement2D>().Setup(moveDirection);

            currentObjectCount++;   // ���� ������Ʈ ���� ����
            objectSpawnTime = 0.0f; // �ð� �ʱ�ȭ -> 0.5�ʸ� ����� ���ؼ�
>>>>>>> 05a15e54780749b97d7e192b8415de9abb4b8cc4
        }
    }
}
 