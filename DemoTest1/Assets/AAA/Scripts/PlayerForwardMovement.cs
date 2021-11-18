using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerForwardMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 0.00005f;
    public static bool gameEnded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameEnded = false;

    }


    void FixedUpdate()
    {
        float moveYDir = Input.GetAxis("vertical");
        float moveXDir = Input.GetAxis("horizontal");

        if (!gameEnded)
        {
            Vector3 movement = new Vector3(moveXDir, 0, moveYDir);
            rb.AddForce(movement * speed);
        }
            /*Vector3 movement = transform.forward * speed * Time.fixedDeltaTime ;
            rb.MovePosition(rb.position + movement);*/
    }

}
