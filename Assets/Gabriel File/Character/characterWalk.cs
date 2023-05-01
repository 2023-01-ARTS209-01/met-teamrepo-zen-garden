using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterWalk : MonoBehaviour
{
    private Animator animator;
    
    private float walkSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       float vertical = Input.GetAxis("Vertical") * walkSpeed * Time.deltaTime; 
       float horizontal = Input.GetAxis("Horizontal") * walkSpeed * Time.deltaTime;

       transform.Translate(horizontal, 0, 0);
       transform.Translate(0, vertical, 0);

       if(vertical > 0)
       {
              animator.SetInteger("direction", 2);
       } else if(vertical < 0)
       {
              animator.SetInteger("direction", 0);
       } else if(horizontal > 0)
       {
              animator.SetInteger("direction", 3);
       } else if(horizontal < 0)
       {
              animator.SetInteger("direction", 1);
       }


    }
}
