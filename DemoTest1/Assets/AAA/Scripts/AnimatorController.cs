using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetTrigger("sittingTrigger");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
