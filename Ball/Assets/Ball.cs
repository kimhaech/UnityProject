using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour // Ball -> Ŭ������ �̸� , MonoBehaviour -> ����Ƽ Ŭ�������� �⺻������ ������ϴ� �ڵ�
{

    float startingPoint;

    // Method
    // Start is called before the first frame update ���۵� ��
    void Start()
    {
        startingPoint = transform.position.z;
    }

    // Update is called once per frame �� �����Ӹ���
    void Update()
    {
        float distance;
        distance = transform.position.z - startingPoint;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up*300);
        }
    }
}
