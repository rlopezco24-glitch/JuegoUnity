using UnityEngine;

public class ActivarLuz : MonoBehaviour
{
    public Light luzEncendida; // Asigna la luz desde el inspector

    private void OnTriggerEnter(Collider other)
    {
        // Comprobamos si el objeto que entra es el jugador
        if (other.CompareTag("Player"))
        {
            if (luzEncendida != null)
            {
                luzEncendida.enabled = true; // Encender la luz
                
            }
        }
    }
}
