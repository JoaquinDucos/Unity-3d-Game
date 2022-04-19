
using UnityEngine;


public class playerCollision : MonoBehaviour
{
public PlayerMovement movement;


       void OnCollisionEnter (Collision collisionInfo)  
       {
       
          if (collisionInfo.collider.tag == "obstaculo")
          {
               movement.enabled = false;
               FindObjectOfType<gameManager>().EndGame();
               
          }
       }
}



    
