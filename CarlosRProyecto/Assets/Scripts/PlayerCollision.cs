using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    public AudioSource tickSource;
    // This function runs when the player collides with an object

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            tickSource = GetComponent<AudioSource>();
            tickSource.Play();
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();

        }
    }
}
