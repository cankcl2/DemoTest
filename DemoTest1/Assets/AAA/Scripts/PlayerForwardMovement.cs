using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerForwardMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 0.025f;
    public static bool gameEnded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameEnded = false;

    }


    void FixedUpdate()
    {

        
            
            Vector3 movement = transform.forward * -speed * Time.fixedDeltaTime ;
            rb.MovePosition(rb.position + movement);

        

    }

}
