using UnityEngine;
using UnityEngine.SceneManagement; // solo si quieres reiniciar la escena

public class KillZone : MonoBehaviour
{
   
    public bool reiniciarEscena = false;
    public Transform puntoRespawn;

    private void OnTriggerEnter(Collider other)
    {
        // Mira que el objeto que entra es el jugador
        if (other.CompareTag("Player"))
        {
            if (reiniciarEscena)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // reinicia la escena actual
            }
            else
            {
                // Respawnea donde se indique con el punto de respawn (EmptyObject)
                if (puntoRespawn != null)
                {
                    CharacterController cc = other.GetComponent<CharacterController>(); 
                    if (cc != null) cc.enabled = false; // desactiva el CharacterController para evitar problemas de colisiones

                    other.transform.position = puntoRespawn.position;

                    if (cc != null) cc.enabled = true; // reactiva el CharacterController
                }
               
            }
        }
    }
}
