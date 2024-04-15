using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    private int collisionCount = 0;
  
    void onTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sphere"))
        {
            collisionCount++;
            Debug.Log("Collision count: " + collisionCount);
        }
    }
}
