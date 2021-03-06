using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D Col)        // This method is called whenever a collision is detected, and passes the Component which Food collided with
    {
        Debug.Log("Collision Detected");
        gameObject.SetActive(false);                // Sets Food to inactive, so it does not show up. Could also delete entirely
    }

    // We could easily add a check to see who Col belongs to, and only despawn the food if it's touched by a player
}
