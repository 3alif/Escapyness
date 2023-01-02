using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    bool Lefting;
    bool Righting;
    public float Forward = 1000f;
    public float Sideway = 250;

    public void Left()
    {
        Lefting = true;
    }

    public void Right()
    {
        Righting = true;
    }

    public void Down()
    {
        Lefting = false;
        Righting = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(Forward * Time.deltaTime, 0, 0);

        if (Lefting)
        {
            Debug.Log("Gone Left");
            rb.AddForce(0, 0, Sideway * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Righting)
        {
            Debug.Log("Gone Right");
            rb.AddForce(0, 0, -Sideway * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
