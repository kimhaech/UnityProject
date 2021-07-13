using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailZone : MonoBehaviour
{
    void OnTriggerEnter(Collider collider) // FailZone �� ��������
    {
        if(collider.gameObject.name == "Ball")  // Ball�̶�� ������Ʈ�� ���
        {
            GameObject.Find("GameManager").SendMessage("RestartGame");  
            // ���� ������Ʈ �� ���� �Ŵ������ ���� ã�� �޼��� ����
            // "Game" ���� �ٽ� �����Ѵ�
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
