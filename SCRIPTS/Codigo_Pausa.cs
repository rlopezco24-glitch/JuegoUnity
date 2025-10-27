using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Codigo_Pausa : MonoBehaviour
{
    
    public GameObject ObjetoMenuPausa; // Objeto del menú de pausa
    public bool Pausa = false; // Estado de pausa
    public GameObject GrupoSalir; // Grupo de opciones de salir del juego


    // Update is called once per frame
    void Update() // Detectar la tecla de pausa
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Pausa == false)
            {
                ObjetoMenuPausa.SetActive(true);
                Pausa = true;

                Time.timeScale = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;

              /**AudioSource[] sonidos = FindObjectsOfType<AudioSource>();
                for (int i = 0; i < sonidos.Length; i++)
                {
                    sonidos[i].Play();
                }*/
            }
            else if (Pausa == true)
            {
                Resumir();
            }

        }
    }
    public void Resumir() // Reanudar el juego
    {
        ObjetoMenuPausa.SetActive(false);
        GrupoSalir.SetActive(false);
        Pausa = false;

        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void IrAlMenu(string NombreMenu) // "Menu_Principal"
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(NombreMenu);
    }
    public void SalirdelJuego() // Salir del juego
    {
        Application.Quit();
    }
}

