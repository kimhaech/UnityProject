using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    int[] students = new int[30];
    // Start is called before the first frame update
    void Start()
    {
        students[0] = 87;
        Debug.Log(students[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
