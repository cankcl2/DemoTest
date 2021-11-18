using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    private float speedModifier = 0.008f;
    float speed = 18f;
    Rigidbody rb;
    public GameObject dashesParent;
    public GameObject prevDash;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        #region Keyboard Controller
         var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, 0, 0) * (speed * Time.deltaTime));
        transform.position = new Vector3(
                Mathf.Clamp(transform.position.x, -5.25f, 2.0f),
                transform.position.y,
                transform.position.z - speed * Time.fixedDeltaTime);
        #endregion

        #region Touch Controller
        if (Input.touchCount > 0)
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
                    transform.position.z - speed * Time.fixedDeltaTime);
            }
        }
        #endregion
        //Debug.Log(transform.position.z);

       
    }
    public void HaveDashes(GameObject dash)
    {
        dash.transform.SetParent(dashesParent.transform);
        Vector3 pos = prevDash.transform.localPosition;
        pos.y -= 0.96f;
        dash.transform.localPosition = pos;

        Vector3 karakterPos = transform.localPosition;
        karakterPos.y += 0.96f;
        transform.localPosition = karakterPos;
        prevDash = dash;

        prevDash.GetComponent<BoxCollider>().isTrigger = false;
    }
}
