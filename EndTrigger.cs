
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

public gameManager GameManager;

void OnTriggerEnter()
   {
       GameManager.CompleteLevel() ; 
   }
   
}
