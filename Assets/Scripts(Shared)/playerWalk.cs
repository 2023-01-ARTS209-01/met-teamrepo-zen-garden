using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerWalk : MonoBehaviour
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

        if(vertical > 0) //North
        {
            animator.SetInteger("direction", 0);

        } else if (vertical < 0) { // South

            animator.SetInteger("direction", 2);

        }

        if(horizontal > 0) // East
        {
            animator.SetInteger("direction", 1);

        } else if (horizontal < 0) { // West

            animator.SetInteger("direction", 3);

        }
            



    }
}
