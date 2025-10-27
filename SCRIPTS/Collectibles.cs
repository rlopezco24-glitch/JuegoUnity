using UnityEngine;

public class Collectible : MonoBehaviour
{
    private bool recogido = false;

    void OnTriggerEnter(Collider other)
    {
        if (recogido) return;

        if (other.CompareTag("Player"))
        {
            recogido = true;

            // Buscar el GameManager y sumar el coleccionable
            GameManager gm = FindAnyObjectByType<GameManager>();
            if (gm != null)
                gm.AddCollectible();

            // Desactivar o destruir el objeto para evitar múltiples conteos
            gameObject.SetActive(false);
        }
    }
}
