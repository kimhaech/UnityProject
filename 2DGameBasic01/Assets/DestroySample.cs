using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySample : MonoBehaviour
{
    [SerializeField]
    private GameObject playerObject;

    private void Awake()
    {
        // Destroy(playerObject.GetComponent<PlayerController>()); // playerObject의 PlayerController 컴포넌트를 삭제
        Destroy(playerObject);  // playerObject 삭제
    }
}