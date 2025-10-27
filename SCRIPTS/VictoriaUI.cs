using TMPro;
using UnityEngine;

public class VictoriaUI : MonoBehaviour
{
    public TMP_Text textoColeccionables;


    void Start()
    {
        
        textoColeccionables.text = $"Has Encontrado el Cofre: {GameData.coleccionablesRecogidos}/{GameData.coleccionablesTotales}"; // Mostrar coleccionables del Nivel 2
    }
}