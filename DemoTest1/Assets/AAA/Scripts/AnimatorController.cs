using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public static AnimatorController instance;
    Animator animatorForPlayer;
    void Start()
    {
        animatorForPlayer = GetComponent<Animator>();
        animatorForPlayer.SetTrigger("sittingTrigger");
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    public void DyingAnimationCaller()
    {
        animatorForPlayer.SetBool("isDead", true);
        
    }
}
