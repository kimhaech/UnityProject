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
        }
    }
}
 