using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AITank : MonoBehaviour {

    public float radius = 10;
    public int numWaypoints = 5;
    public int current = 0;
    List<Vector3> waypoints = new List<Vector3>();
    public float speed = 10;
    public Transform player;

    [SerializeField] Transform[] Positions;
    [SerializeField] float Speed;
    int NextPosIndex;
    Transform NextPos;

    public void OnDrawGizmos()
    {
        if (!Application.isPlaying)
        {
            // Task 1
            // Put code here to draw the gizmos
            // Use sin and cos to calculate the positions of the waypoints 
            // You can draw gizmos using
            // Gizmos.color = Color.green;
            // Gizmos.DrawWireSphere(pos, 1);
        }
    }

    // Use this for initialization
    void Awake () {
        // Task 2
        // Put code here to calculate the waypoints in a loop and 
        // Add them to the waypoints List
    }

    void Start()
    {
        NextPos = Positions[0];
    }

    // Update is called once per frame
    void Update () {
        // Task 3
        // Put code here to move the tank towards the next waypoint
        // When the tank reaches a waypoint you should advance to the next one


        // Task 4
        // Put code here to check if the player is in front of or behine the tank
        // Task 5
        // Put code here to calculate if the player is inside the field of view and in range
        // You can print stuff to the screen using:
        MoveGameObject();

        GameManager.Log("Hello from th AI tank");
    }

    void MoveGameObject()
    {
        if (transform.position == NextPos.position)
        {
                NextPosIndex++;
                if (NextPosIndex >= Positions.Length)
                {
                    NextPosIndex = 0;
                }
               NextPos = Positions[NextPosIndex];
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, NextPos, Speed * Time.deltaTime);
        }
    }
}
