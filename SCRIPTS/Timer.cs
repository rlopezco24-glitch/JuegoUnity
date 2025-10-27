using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
   
    public float timer = 30f;
    public TMP_Text timerTexto;
    public bool todosLosObjetosRecogidos = false;
    public float tiempoInicial; // visible para el GameManager
    private bool juegoTerminado = false;

    //Empezar el temporizador
    void Start()
    {
        tiempoInicial = timer;
    }

    //Actualizar el temporizador cada frame
    void Update()
    {
        if (juegoTerminado) return;

        if (!todosLosObjetosRecogidos) // Solo contar el tiempo si no se han recogido todos los objetos
        {
            if (timer > 0)
            {
                timer -= Time.deltaTime; // Disminuir el temporizador
                timerTexto.text = timer.ToString("F0");
            }
            else
            {
                timer = 0;
                timerTexto.text = "0";
                juegoTerminado = true;
                SceneManager.LoadScene("Derrota");
            }
        }
    }
}