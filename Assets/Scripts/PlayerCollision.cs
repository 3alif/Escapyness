using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Collider")
        {
            movement.enabled = false;
            FindObjectOfType<Manager>().GameOver();
        }
    }
}
