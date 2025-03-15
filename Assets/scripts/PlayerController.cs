using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    //Variables related to player character movement
    public InputAction MoveAction; 
    Vector2 move;
    Rigidbody2D rigidbody2d;
    public float speed = 3.0f;

    void Start()
    {
        MoveAction.Enable();
        rigidbody2d = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        // Read input movement
        move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);

        float horizontal = 0.0f;
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            horizontal = -1.0f;
        }
        else if (Keyboard.current.rightArrowKey.isPressed)
        {
            horizontal = 1.0f;
        }
        Debug.Log(horizontal);


        float vertical = 0.0f;
        if (Keyboard.current.upArrowKey.isPressed)
        {
            vertical = 1.0f;
        }
        else if (Keyboard.current.downArrowKey.isPressed)
        {
            vertical = -1.0f;
        }
        Debug.Log(vertical);

        // Move the transform position
        Vector2 position = (Vector2)transform.position + move * 3.5f * Time.deltaTime;
        Debug.Log(move);
        transform.position = position;
    }

    void FixedUpdate()
    {
        // Move using Rigidbody2D physics
        Vector2 position = rigidbody2d.position + move * 3.0f * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }
} 