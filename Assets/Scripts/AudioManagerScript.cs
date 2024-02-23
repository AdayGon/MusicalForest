using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    // Se crea una referencia est�tica al AudioManager para hacerlo Singleton
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

    // M�todo para reproducir la m�sica de fondo
    public void PlayBackgroundMusic()
    {
        if (!backgroundMusic.isPlaying)
        {
            backgroundMusic.Play();
        }
    }

    // M�todo para detener la m�sica de fondo
    public void StopBackgroundMusic()
    {
        if (backgroundMusic.isPlaying)
        {
            backgroundMusic.Stop();
        }
    }
}