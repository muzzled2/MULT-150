using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int start = 22;
        int end = 100;

        for (int num = start; num <= end; num += 2)
        {
            Debug.Log(num);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
