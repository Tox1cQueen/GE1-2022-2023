using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMe : MonoBehaviour
{
    [Range(0, 360)]
    public float speed = 90;
    public Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        rotation = new Vector3(0,2,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation*speed*Time.deltaTime);
    }
}
