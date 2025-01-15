using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha2))
        {
            animator.SetTrigger("button2Trigger");
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            animator.SetBool("button1Boolean",true);
            
        }

        if (Input.GetKeyUp(KeyCode.Alpha1))
        {
            animator.SetBool("button1Boolean",false);
        }
    }
}
