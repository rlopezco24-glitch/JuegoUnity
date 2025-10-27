using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;
public class MenuPrincipal : MonoBehaviour
{
    public GameObject panelMenu;
    public GameObject panelOptions;
    // Empezar con el panel de menú principal activo y el de opciones inactivo
    public void OpenOptionsPanel()
    {
        panelMenu.SetActive(false);
        panelOptions.SetActive(true);
    }
    public void OpenMainMenuPanel()
    {
        panelMenu.SetActive(true);
        panelOptions.SetActive(false);
    }
    // Salir del juego
    public void Exit()
    {
        Application.Quit();
    }

    // Cargar la siguiente escena (nivel de juego)
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    // Cargar un nivel específico por nombre
    public void Niveles(string nivel) {
        SceneManager.LoadScene(nivel);
}
    }