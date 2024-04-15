using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript2 : MonoBehaviour
{
    float moveSpeed = 5f;
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Sphere");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.A))

        {
            movement += Vector3.left;
        }

        if (Input.GetKey(KeyCode.D))

        {
            movement += Vector3.right;
        }
        
        target.transform.Translate(movement * moveSpeed * Time.deltaTime);
        
    }
}
