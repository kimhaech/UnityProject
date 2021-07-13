using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailZone : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.name == "Ball")  // Ball이라는 오브젝트인 경우
        {
            Application.LoadLevel("Game");  // unity파일을 저장할 때 Game이라는 이름으로 저장했기 때문
            // "Game" 판을 다시 시작한다
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
