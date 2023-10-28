using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float moveX;
    private float moveY;
    private Vector2 direction;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direction = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();

        Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, - direction);
        // transform.rotation = Quaternion.Rotate(transform.rotation, toRotation, 1);
        transform.rotation = Quaternion.Euler(0, 0, toRotation.eulerAngles.z);
    }

    /// <summary>
    /// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
    /// </summary>
    void FixedUpdate()
    {
        direction = new Vector2(moveX, moveY).normalized;
        rb.velocity = direction * speed;
        // Physics Calculations
    }

    void ProcessInputs() {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
    }
}
