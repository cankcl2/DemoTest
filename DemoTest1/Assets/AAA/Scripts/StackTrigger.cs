using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pick")
        {
            StackManager.instance.Pickup(other.gameObject, true, "BouysUnderPlayer",false);
        }
        if (other.tag == "WallObstacles")
        {
            StackManager.instance.DestroyFunc();
        }
    }
}
