using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailZone : MonoBehaviour
{
    void OnTriggerEnter(Collider collider) // FailZone 에 떨어졌다
    {
        if(collider.gameObject.name == "Ball")  // Ball이라는 오브젝트인 경우
        {
            // GameObject.Find("GameManager").SendMessage("RestartGame");  
            // GameObject gm = GameObject.Find("GameManager"); // GameManager라는 게임 오브젝트를 찾는다
            // GameManager gmComponent = gm.GetComponent<GameManager>();   // GameManager의 컴포넌트를 가져온다
            GameManager gmComponent = GameObject.Find("GameManager").GetComponent<GameManager>();
            gmComponent.RestartGame();
            // 게임 오브젝트 중 게임 매니저라는 것을 찾아 메세지 보냄
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
