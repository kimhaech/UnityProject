using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider col)  // trigger 시
    {
        if(col.gameObject.name == "Ball")
        {
            Destroy(gameObject); // 스크립트가 추가되어있는 게임 오브젝트를 뜻한다.
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
