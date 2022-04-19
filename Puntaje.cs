
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
     public Transform Player;
     public Text puntajeTexto;
    // Update is called once per frame
    void Update()
    {
       puntajeTexto.text = Player.position.z.ToString("0");
    }
}
