using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClashCollision : MonoBehaviour
{  private Rigidbody rb;
    // Start is called before the first frame update

    public GameObject redCylinder;
    void Start()
    { 
        rb = GetComponent<Rigidbody>(); // if you don't specify the component it will Get the RB off the object the comp. is attached to. Otherwise: eg floor.GetComponent. 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)  //function that states events on specific instance 'collision' of type collision
    {
        if (collision.gameObject.name == "redCylinder") //refers to game object with which player collides
        {
            Debug.Log("Hit red cylinder"); //collision statement with cylinderAvoid (redCylinder)
        }

    }
}
