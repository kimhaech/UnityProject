using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : Obstacle // Obstacle을 상속
{
    public GameObject stone;    // prefab stone을 사용하기 위한 오브젝트

    float timeCount = 0;    // 시간을 카운트하기 위한 변수 선언
    void Update()   // override
    {
        base.Update();  // 부모 클래스의 Update를 사용
        timeCount += Time.deltaTime;    // 지난 update에서 지금 update사이의 시간
        if(timeCount > 3)   // timecount가 3을 넘긴 경우
        {
            Instantiate(stone, transform.position, Quaternion.identity);    // 현재 shooter의 위치에서 생성
            // 새로운 게임 오브젝트 생성
            timeCount = 0;
        }
    }
}
