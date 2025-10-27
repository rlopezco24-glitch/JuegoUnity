using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   
    public AudioSource audioSource; // AudioSource con el sonido 


    public TMP_Text collectiblesProgressText; // Mostrar el progreso de coleccionables

    private int collectiblesNumber = 0;
    private int totalCollectiblesInitial = 0;

    void Start()
    {
        // Contamos todos los objetos con tag "Collectible"
        totalCollectiblesInitial = GameObject.FindGameObjectsWithTag("Collectible").Length;

        if (collectiblesProgressText != null)
            collectiblesProgressText.text = $"{collectiblesNumber}/{totalCollectiblesInitial}";
    }

    public void AddCollectible()
    {
        // Reproducir sonido del AudioSource asignado
        if (audioSource != null)
            audioSource.Play();

        collectiblesNumber++;
        // Actualizar el texto de progreso
        if (collectiblesProgressText != null)
            collectiblesProgressText.text = $"{collectiblesNumber}/{totalCollectiblesInitial}";

        Debug.Log($"Collectible recogido: {collectiblesNumber}/{totalCollectiblesInitial}");

        // Comprobar si se han recogido todos los coleccionables
        if (collectiblesNumber >= totalCollectiblesInitial)
        {
            string escenaActual = SceneManager.GetActiveScene().name;

            if (escenaActual == "Escena1.1")
            {
               
                SceneManager.LoadScene("Escena2");
            }
            else if (escenaActual == "Escena2")
            {
               

                // Guardar coleccionables solo del Nivel 2
                GameData.coleccionablesRecogidos = collectiblesNumber;
                GameData.coleccionablesTotales = totalCollectiblesInitial;

                SceneManager.LoadScene("Win");
            }
        }
    }
}
