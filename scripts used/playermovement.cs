using UnityEngine;

public class playermovement : MonoBehaviour
{
    // this is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 2000f;

    // we marked this as "Fixed"Update because 
    // we are it to mess with physics.
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce* Time.deltaTime); //Add a force of 2000 on the z-axis

        // Adding movement keys
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        // Adding movement keys
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<gamemanager>().EndGame();
        }
    }
}
