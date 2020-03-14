﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpHeight = 5f;
    public bool isGrounded = false;

    public Animator animator;

    void Update()
    {
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));

        transform.localRotation = new Quaternion(0,0,0,0);
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true) 
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpHeight), ForceMode2D.Impulse);
        }
    }
}
