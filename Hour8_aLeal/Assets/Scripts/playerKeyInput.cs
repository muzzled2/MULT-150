using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerKeyInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.M))
            Debug.Log("The 'M' key is pressed down");
        if(Input.GetKey(KeyCode.O))
            Debug.Log("The 'O' key is pressed down");
    }
}
