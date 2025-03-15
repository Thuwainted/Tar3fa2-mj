using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using static UnityEditor.Searcher.SearcherWindow.Alignment;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour 
{
    // Called once when the object is initialized
    void Start()
    {
        
    }

    // Called once per frame
    void Update()
    {
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
        Vector2 position = transform.position;
        position.x = position.x + 0.1f;
        position.y = position.y + 0.1f * vertical;
        transform.position = position;

    }
}