using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");

        //fixes inversion issue and increases sensitivity
        myVal *= -2f;
        mxVal *= 2f;

        if (mxVal != 0)
        transform.Rotate(0f,mxVal, 0f);
        if (myVal != 0)
        transform.Rotate(myVal,0f, 0f);
     ;
    }
}
