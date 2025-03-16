using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HealthCollectible : MonoBehaviour
{
    public AudioClip collectedClip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)
        {
            controller.ChangeHealth(1);
            controller.PlaySound(collectedClip);
            Destroy(gameObject);
        }
    }
}
