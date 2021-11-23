using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackManager : MonoBehaviour
{
    public static StackManager instance;
    [SerializeField] private float distanceBetweenObjects;
    [SerializeField] private Transform prevObjectTransform;
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
        distanceBetweenObjects = prevObjectTransform.localScale.y/2;
    }
    
    public void Pickup(GameObject pickedObject, bool needTag = false, string tag = null, bool downOrUp = true)
    {
        if (needTag)
        {
            pickedObject.tag = tag;
        }
        pickedObject.transform.parent = parent;
        Vector3 desPos = prevObjectTransform.localPosition;
        desPos.y += downOrUp ? distanceBetweenObjects : -distanceBetweenObjects;
        pickedObject.transform.localPosition = desPos;

        Player.transform.position = new Vector3(transform.position.x, transform.position.y + 0.48f, transform.position.z);

        prevObjectTransform = pickedObject.transform;
    }
    public void DestroyFunc()
    {
        var bouys = GameObject.FindGameObjectsWithTag("BouysUnderPlayer");

        if (bouys != null && bouys.Length != 0 && bouys.Length != 1)
        {
            Player.transform.position = new Vector3(transform.position.x, transform.position.y - 0.48f, transform.position.z);
            prevObjectTransform = bouys[bouys.Length - 2].transform;
            bouys[bouys.Length - 1].tag = "Untagged";
            Destroy(bouys[bouys.Length-1]);

        }
        else if (bouys.Length == 1)
        {
            //Add Scene 
        }
    }
}
