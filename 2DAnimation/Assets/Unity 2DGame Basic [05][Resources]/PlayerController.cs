using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;  // Animator Ÿ���� ����

    private void Awake()
    {
        animator = GetComponent<Animator>();    // ������Ʈ ��������
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))    // �����̽��� �Է� ��
        {
            animator.SetTrigger("isDie");   // isDie Ʈ���� Ȱ��ȭ
        }    
    }

    public void OnDieEvent()
    {
        Debug.Log("End of Die Animation");
    }
}
