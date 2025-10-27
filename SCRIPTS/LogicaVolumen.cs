using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class LogicaVolumen : MonoBehaviour
{

    public Slider slider;
    public float sliderValor;
    public RawImage imagenSilencio;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Cargar el valor guardado en PlayerPrefs
        slider.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f);
        AudioListener.volume = slider.value;
        RevisarSiEstoyMute();

    }

    public void ChangeSlider(float valor) {
        //Cambiar el valor del volumen y guardarlo en PlayerPrefs
        slider.value = valor;
        PlayerPrefs.SetFloat("volumenAudio", sliderValor); 
        AudioListener.volume = slider.value; 
        RevisarSiEstoyMute();

    }

    public void RevisarSiEstoyMute() {
        //Revisar si el valor del slider es 0 para mostrar la imagen de mute
        if (slider.value == 0)
        {
            imagenSilencio.enabled = true; 
        }
        else
        {
            imagenSilencio.enabled = false;
        }
    }
   
}
