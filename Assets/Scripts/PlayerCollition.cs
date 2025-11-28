using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollition : MonoBehaviour
{
    public PlayerMove movement;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstecle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManger>().EndGame();
        }
    }
}
