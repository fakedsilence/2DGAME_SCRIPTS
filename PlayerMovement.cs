using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0f;
    public GameObject player;
    private Rigidbody2D rigid2D;

    private void Start() { 
        rigid2D = player.GetComponent<Rigidbody2D>();
    }

    private void Update() {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        rigid2D.velocity = new Vector3(moveX,moveY,0) * speed * Time.fixedDeltaTime;
    }
}
