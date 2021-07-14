using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWork : MonoBehaviour
{
    public GameObject ball; // public 선언시 Inspector 내에 오브젝트를 드래그해서 카메라의 대상을 지정할 수 있다.

    // Start is called before the first frame update
    void Start()
    {
        // ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0
            , ball.transform.position.y+3
            , ball.transform.position.z - 14);
    }
}
