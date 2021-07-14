using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour // Ball -> 클래스의 이름 , MonoBehaviour -> 유니티 클래스에서 기본적으로 적어야하는 코드
{

    float startingPoint;

    // Method
    // Start is called before the first frame update 시작될 때 
    void Start()
    {
        startingPoint = transform.position.z;
    }

    // Update is called once per frame 매 프레임마다
    void Update()
    {
        float distance;
        distance = transform.position.z - startingPoint;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up*300);
            
            /* Rigidbody ballRigid;
             * ballRigid = gameObject.GetComponent<Rigidbody>();
             * ballRigid.AddForce(Vector3.up*300);
             * 위 코드와 같은 기능
             * ballRigid.mass -> mass는 rigidbody가 가지는 질량을 뜻함
             */
        }
    }
}
