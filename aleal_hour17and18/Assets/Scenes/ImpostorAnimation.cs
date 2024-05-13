using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpostorAnimation : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("Hurt");
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("Grow");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("Spin");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("Hover");
        }
    }
}
