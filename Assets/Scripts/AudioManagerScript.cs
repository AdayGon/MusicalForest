using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    // Se crea una referencia estática al AudioManager para hacerlo Singleton
    private static AudioManagerScript _instance;
    public static AudioManagerScript Instance { get { return _instance; } }

    public AudioSource backgroundMusic;

    void Awake()
    {
        // Si no hay una instancia del AudioManager, se establece
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject); // No destruye el objeto al cambiar de escena
        }
        else
        {
            // Si ya hay una instancia del AudioManager, destruye este objeto
            Destroy(gameObject);
        }
    }

    // Método para reproducir la música de fondo
    public void PlayBackgroundMusic()
    {
        if (!backgroundMusic.isPlaying)
        {
            backgroundMusic.Play();
        }
    }

    // Método para detener la música de fondo
    public void StopBackgroundMusic()
    {
        if (backgroundMusic.isPlaying)
        {
            backgroundMusic.Stop();
        }
    }
}