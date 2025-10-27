using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoriaDerrota : MonoBehaviour
{
    public void Start()
    {
        // Asegurarse de que el cursor est� visible y desbloqueado
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }


    public void IrAlMenu(string nombreMenu)
    {
        // Cargar la escena del men� principal
        SceneManager.LoadScene(nombreMenu);
    }


    public void CargarEscena(string nombreEscena)
    {
        // Cargar una escena espec�fica por nombre
        SceneManager.LoadScene(nombreEscena);
    }


}

