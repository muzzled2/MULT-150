using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sphere"))
        {
            if (gameObject.CompareTag("LTrigger"))

            {
                Debug.Log("Sphere has entered the left trigger");
            }


            else if (gameObject.CompareTag("RTrigger"))
            {
                Debug.Log("Sphere has entered the right trigger");
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Sphere"))
        {
            if (gameObject.CompareTag("LTrigger"))

            {
                Debug.Log("Sphere is staying in the left trigger");
            }

            else if (gameObject.CompareTag("RTrigger"))
            {
                Debug.Log("Sphere is staying in the right trigger");
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Sphere"))
        {
            if (gameObject.CompareTag("LTrigger"))

            {
                Debug.Log("Sphere exited the left trigger");
            }

            else if (gameObject.CompareTag("RTrigger"))
            {
                Debug.Log("Sphere exited the right trigger");
            }
        }
    }

}
