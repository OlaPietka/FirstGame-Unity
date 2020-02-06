using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float flidewaysForce = 500f;

    // Update is called once per frame
    void FixedUpdate() //jak uzywam fizyki to FixedUpdate
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Time.deltaTime zeby wygladalo tak samo na kazdym systemie

        if ( Input.GetKey("d"))
        {
            rb.AddForce(flidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-flidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
