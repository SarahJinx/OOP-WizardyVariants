using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 input;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        input.Normalize(); // Diagonals arent faster
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + input * speed * Time.fixedDeltaTime);
    }
}