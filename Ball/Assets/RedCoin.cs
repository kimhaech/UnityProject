using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCoin : MonoBehaviour
{
    void OnTriggerEnter(Collider col)  // trigger ��
    {
        if (col.gameObject.name == "Ball")
        {
            GameObject.Find("GameManager").SendMessage("RedCoinStart");
            // ���� �Ŵ����� ã�� �޼��� ����
            Destroy(gameObject); // ��ũ��Ʈ�� �߰��Ǿ��ִ� ���� ������Ʈ�� ���Ѵ�.
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
