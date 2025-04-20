using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    public Animator animator;
    int IsWalkingHash, IsRunningHash;
   
    void Start()
    {
        animator = GetComponent<Animator>();
        IsWalkingHash = Animator.StringToHash("IsWalking");
        IsRunningHash = Animator.StringToHash("IsRunning");
    }

    
    void Update()
    {
        bool IsRunning = animator.GetBool(IsRunningHash);
        bool IsWalking = animator.GetBool(IsWalkingHash);
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");

        if (forwardPressed)
        {
            animator.SetBool(IsWalkingHash, true);
        }
        else animator.SetBool(IsWalkingHash, false);
        if (runPressed)
        {
            animator.SetBool (IsRunningHash, true);
        }
        else animator.SetBool(IsRunningHash, false);
    }
}
