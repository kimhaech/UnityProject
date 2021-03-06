using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float zRotation = transform.localEulerAngles.z;
        zRotation = zRotation - Input.GetAxis("Horizontal");
        transform.localEulerAngles = new Vector3(10, 0, zRotation);

        if (Input.touchCount > 0 || Input.GetMouseButton(0)) // 0 은 마우스 왼쪽 버튼
        {
            Debug.Log("Mouse Down:"+Input.mousePosition);  // 터치 혹은 마우스의 포지션을 반환
            if(Input.mousePosition.x<Screen.width / 2)
            {   // 왼쪽을 클릭
                transform.localEulerAngles = new Vector3(10
                    , 0
                    , transform.localEulerAngles.z+1.0f);
            }
            else
            {   // 오른쪽을 클릭
                transform.localEulerAngles = new Vector3(10
                    , 0
                    , transform.localEulerAngles.z-1.0f);
            }
        }
    }
}
