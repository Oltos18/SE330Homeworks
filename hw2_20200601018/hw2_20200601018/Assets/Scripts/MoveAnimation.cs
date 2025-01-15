using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnimation : MonoBehaviour
{
    public Animator Animator;

    public void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Animator.SetBool("Turn",true);
        }
        else
        {
            Animator.SetBool("Turn",false);
        }
    }
}
