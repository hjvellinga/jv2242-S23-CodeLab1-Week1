using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlleyMovement : MonoBehaviour
{
    public float AlleyBorder = 50f; //indicates border of alley/restart point (equal to BLOCK object)

    public float AlleySpeed = 0.5f; //sets movement speed of alley

    public float AlleySpeedIncrease = 0.001f; //sets increase of movement speed of alley
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position; //calls position of the object within transform component x,y,z axes
        newPosition.z -= AlleySpeed;
        if (newPosition.z < -AlleyBorder) //if new position of the alley is less than the BLOCK object
        {
            newPosition.z = AlleyBorder;
        }
        transform.position = newPosition;
    }
}
