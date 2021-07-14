using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Ball").transform.position;    // �ʱ� Ÿ�� ��ġ -> Ball�� ��ġ
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, 0.1f); // �ش� �������� ���ư��� �Ѵ�.
        transform.Rotate(new Vector3(0, 0, 5)); // z���� �������� 5����ŭ ȸ��

    }

    void OnTriggerEnter(Collider collider) // ���� �ε��� ���
    {
        if (collider.gameObject.name == "Ball")  // Ball�̶�� ������Ʈ�� ���
        {
            GameManager gmComponent = GameObject.Find("GameManager").GetComponent<GameManager>();
            gmComponent.RestartGame();
        }
    }
}
