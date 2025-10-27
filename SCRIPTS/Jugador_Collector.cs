using UnityEngine;

public class Jugador_Collector : MonoBehaviour
{
    GameManager gameManager;

    void Awake()
    {
        gameManager = FindFirstObjectByType<GameManager>(); // Buscar el GameManager en la escena
        if (gameManager == null)
            Debug.LogError("GameManager no encontrado en la escena. Asigna un GameObject con GameManager.");
    }
    void OnControllerColliderHit(ControllerColliderHit hit)
    { // Detectar colisiones con el CharacterController
        if (hit.collider.CompareTag("Collectible"))
        {
            Debug.Log($"Jugador_Collector: Colisión con Collectible: {hit.collider.name}");
            gameManager?.AddCollectible();
            Destroy(hit.collider.gameObject);
        }
    }
}