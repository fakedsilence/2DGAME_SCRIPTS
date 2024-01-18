using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0f;
    public GameObject player;
    private Rigidbody2D rigid2D;

    private Animator animator;

    private void Start()
    {
        rigid2D = player.GetComponent<Rigidbody2D>();
        animator = player.GetComponent<Animator>();
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        rigid2D.velocity = new Vector3(moveX, 0) * speed * Time.fixedDeltaTime;
        setRunning(moveX);
        setToward(moveX);
    }

    private void setToward(float moveX)
    {
        player.transform.localScale = new Vector3(moveX < 0 ? -1 : 1, 1, 1);
    }

    private void setRunning(float moveX)
    {
        animator.SetBool("isRun", moveX != 0);
    }
}
