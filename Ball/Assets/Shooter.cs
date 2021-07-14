using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : Obstacle // Obstacle�� ���
{
    public GameObject stone;    // prefab stone�� ����ϱ� ���� ������Ʈ

    float timeCount = 0;    // �ð��� ī��Ʈ�ϱ� ���� ���� ����
    void Update()   // override
    {
        base.Update();  // �θ� Ŭ������ Update�� ���
        timeCount += Time.deltaTime;    // ���� update���� ���� update������ �ð�
        if(timeCount > 3)   // timecount�� 3�� �ѱ� ���
        {
            Instantiate(stone, transform.position, Quaternion.identity);    // ���� shooter�� ��ġ���� ����
            // ���ο� ���� ������Ʈ ����
            timeCount = 0;
        }
    }
}
