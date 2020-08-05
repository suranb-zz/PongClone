using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float movementSpeed;
    private Vector2 lastPosition;
    private Vector2 lastVelocity;
    private Vector2 lastAcceleration;

    public Rigidbody2D rb;

    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Vector2 position = transform.position;
        Vector2 velocity = (position - lastPosition) / Time.deltaTime;
        Vector2 acceleration = (velocity - lastVelocity) / Time.deltaTime;

        rb.velocity = new Vector2(0, Input.acceleration.y * movementSpeed);

        if (Mathf.Abs(acceleration.magnitude - lastAcceleration.magnitude) < 0.01f)
        {
            // Still
        }
        else if (acceleration.magnitude > lastAcceleration.magnitude)
        {
            Debug.Log("Accelerating");
            rb.velocity = new Vector2(0, Input.acceleration.y * movementSpeed);
            rb.AddForce(transform.up * 1.0f);
        }
        else // Decelerating
        {
            Debug.Log("Decelerating");
            rb.velocity = new Vector2(0, Input.acceleration.y * movementSpeed);
            rb.AddForce(transform.up * -1.0f);
        }
    }
}
