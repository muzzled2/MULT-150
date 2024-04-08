using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBulb : MonoBehaviour
{
    // Start is called before the first frame update
    private Light lightComponent;
    private GameObject target;

    public float inputDelay = 5f;
    private bool canToggleLight = true;

    void Start()
    {
        target = GameObject.Find("Light_Bulb");

        lightComponent = target.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.L) && lightComponent != null)

        {
            lightComponent.enabled = !lightComponent.enabled;

            StartCoroutine(DelayInput());
        }
    }

    IEnumerator DelayInput()
    {
        canToggleLight = false;

        yield return new WaitForSeconds(inputDelay);

        canToggleLight = true;
    }
}

