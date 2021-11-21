using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectDSystem : MonoBehaviour
{
    public AudioSource diamondSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            diamondSound.Play();
            other.GetComponent<ScoreSystem>().theScore++;
            Destroy(gameObject);
        }
    }
}
