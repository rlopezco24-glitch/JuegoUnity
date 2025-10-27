using UnityEngine;

public class MusicManager : MonoBehaviour
{
   private static MusicManager instance;    
    void Start()
    {
        if (instance == null) 
        {
            // Primer instancia, se mantiene

            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            // Ya existe una instancia, se destruye la nueva
            Destroy(this.gameObject);
        }
    }

}