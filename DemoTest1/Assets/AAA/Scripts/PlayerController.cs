using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speedModifier = 0.008f;
    private float speed = 8f;
    Rigidbody rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        
            #region Keyboard Controller
            if (Input.touchCount <= 0)
            {
                var horizontal = Input.GetAxis("Horizontal");
                var vertical = Input.GetAxis("Vertical");
                transform.Translate(new Vector3(horizontal, 0, 0) * (speed * Time.deltaTime));
                transform.position = new Vector3(
                        Mathf.Clamp(transform.position.x, -5.25f, 2.0f),
                        transform.position.y,
                        transform.position.z - speed * Time.fixedDeltaTime);
            }
            #endregion

            #region Touch Controller
            else if (Input.touchCount > 0)
            {
                transform.position = new Vector3(
                    Mathf.Clamp(transform.position.x, -4.0f, 1.0f),
                    transform.position.y,
                    transform.position.z);
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Moved)
                {
                    transform.position = new Vector3(
                        transform.position.x + touch.deltaPosition.x * -speedModifier,
                        transform.position.y,
                        transform.position.z);
                }
            }
            #endregion
        
        
        //Debug.Log(transform.position.z);
    }
}
