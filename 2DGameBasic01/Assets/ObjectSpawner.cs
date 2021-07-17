using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject boxPrefab;

    private void Awake()
    {
        /*  Instantiate(boxPrefab, new Vector3(3, 3, 0), Quaternion.identity); // 게임오브젝트(프리팹)를 복제해서 생성
            Instantiate(boxPrefab, new Vector3(-1, -2, 0), Quaternion.identity); */
        //Instantiate(boxPrefab, new Vector3(2, 1, 0), rotation);
        Quaternion rotation = Quaternion.Euler(0, 0, 45);

        GameObject clone = Instantiate(boxPrefab, Vector3.zero, rotation);

        clone.name = "Box001";  // 이름 설정
        
        clone.GetComponent<SpriteRenderer>().color = Color.black;   //black 색상 설정

        clone.transform.position = new Vector3(2, 1, 0);    // 위치
        clone.transform.localScale = new Vector3(3, 2, 1);  // 크기
    }
}
