using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    public int numberofLamps = 10;
    public float spacing = 6.0f;

    void Start()
    {
        Vector3 startPosition = transform.position - new Vector3(spacing * (numberofLamps - 1) / 6f, 0, 0);

        for (int i =0; i < numberofLamps; i++)
        {
            Vector3 position = startPosition + new Vector3(i * spacing, 0, 0);
            Instantiate(prefab, position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if
            (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if
            (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
}
