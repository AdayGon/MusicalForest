using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManagerScript : MonoBehaviour
{
    // Se crea una referencia est�tica al AudioManager para hacerlo Singleton
    private static AudioManagerScript _instance;
    public static AudioManagerScript Instance { get { return _instance; } }

    public AudioSource audioSource;
    private bool musicStarted = false;

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
    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Aqu� puedes cambiar la m�sica seg�n la escena
        PlayMusicForScene(scene.name);
    }

    void PlayMusicForScene(string sceneName)
    {
        if (sceneName == "Nivel")
        {
            // Aqu� establece la m�sica para la escena 1
            audioSource.Stop();
        }
    }
}