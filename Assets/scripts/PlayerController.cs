using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour 
{
    // Called once when the object is initialized
    void Start()
    {
        
    }

    // Called once per frame
    void Update()
    {
        
        Vector2 position = transform.position;
        position.x = position.x + 0.1f;
        transform.position = position;

    }
}