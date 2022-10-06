using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public int loops = 10;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        for (var j = 0; j < loops; j++)
        {
            float radius = 1.5f * j;

            int circumference = (int)(2 * Mathf.PI * radius);

            for (var i = 0; i < circumference; i++)
            {
                float cx = transform.position.x;
                float cy = transform.position.y;

                float angle = (2 * Mathf.PI / circumference) * i;

                float x = cx + radius * Mathf.Cos(angle);
                float y = cy + radius * Mathf.Sin(angle);

                GameObject instance = Instantiate(prefab);

                instance.transform.position = new Vector3(x, y, 5);
            }
        }

    }
}
