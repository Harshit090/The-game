using UnityEngine;

public class collision_detector : MonoBehaviour
{
    public playermovement movement;

    void OnCollisionEnter (Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "obsticle")
        {
            movement.enabled = false;
            FindObjectOfType<gamemanager>().EndGame();
        }
    }
}
