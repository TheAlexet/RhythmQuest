using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Animator animator;
    CharacterController characterController;

    public float turnSpeed = 100;
    public float speed = 5;

    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(-y, 0.0f, x);
        if(movement != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(movement);
        }

        transform.Translate(movement * speed * Time.deltaTime, Space.World);
        characterController.SimpleMove(movement * speed);
        if(Input.GetKey("w") || Input.GetKey("s") || Input.GetKey("a") || Input.GetKey("d"))
        {
            animator.SetBool("isWalking", true);
        }

        if(!Input.GetKey("w") && !Input.GetKey("s") && !Input.GetKey("a") && !Input.GetKey("d"))
        {
            animator.SetBool("isWalking", false);
        }
    }
}
