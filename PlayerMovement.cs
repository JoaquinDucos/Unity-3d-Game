using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
public Rigidbody rb;

public float fuerzaEmpuje = 800f;
public float fuerzaLateral = 650f;

    void FixedUpdate()
    {
        rb.AddForce(0, 0, fuerzaEmpuje * Time.deltaTime);
        
        if (Input.GetKey("d"))
        {
           rb.AddForce( fuerzaLateral * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
           rb.AddForce(- fuerzaLateral * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
       /* if (Input.GetKey("w"))
        {
           rb.AddForce(0, fuerzaEmpuje * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("s"))
        {
           rb.AddForce(0, - fuerzaEmpuje * Time.deltaTime, 0, 0);
        } */
        if (rb.position.y < 2.98f)
        {
             FindObjectOfType<gameManager>().EndGame();
        }
     }
  }

