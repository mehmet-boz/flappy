using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float upAmount = 0;
    public bool direction = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidBody.velocity = Vector2.up * upAmount;
        }

        // if (direction == true)
        // {
        //     myRigidBody.velocity = Vector2.up * upAmount;
        // }
        // else
        // {
        //     myRigidBody.velocity = Vector2.down * upAmount;
        // }

        //transform.Rotate(new Vector3(0, 0, 15));
    }
}
