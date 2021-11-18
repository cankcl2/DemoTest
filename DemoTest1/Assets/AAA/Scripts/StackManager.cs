using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackManager : MonoBehaviour
{
    public static StackManager instance;
    [SerializeField] private float distanceBetweenObjects;
    [SerializeField] private Transform prevObject;
    [SerializeField] private Transform parent;
    public GameObject Player;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        distanceBetweenObjects = prevObject.localScale.y/2;
    }
    
    public void Pickup(GameObject pickedObject, bool needTag = false, string tag = null, bool downOrUp = true)
    {
        if (needTag)
        {
            pickedObject.tag = tag;
        }
        pickedObject.transform.parent = parent;
        Vector3 desPos = prevObject.localPosition;
        desPos.y += downOrUp ? distanceBetweenObjects : -distanceBetweenObjects;
        pickedObject.transform.localPosition = desPos;

        Player.transform.position = new Vector3(transform.position.x, transform.position.y + 0.48f, transform.position.z);

        prevObject = pickedObject.transform;
    }
    public void Stairs(GameObject pickedObject, bool needTag = false, string tag = null, bool downOrUp = true)
    {
        if (needTag)
        {
            pickedObject.tag = tag;
        }
        pickedObject.transform.parent = parent;
        Vector3 desPos = prevObject.localPosition;
        desPos.y += downOrUp ? distanceBetweenObjects : -distanceBetweenObjects;
        desPos.z += pickedObject.transform.localScale.z;

        pickedObject.transform.localPosition = desPos;

        prevObject = pickedObject.transform;
    }
}
