using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManagerScript : MonoBehaviour
{
    // Se crea una referencia estática al AudioManager para hacerlo Singleton
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
        // Aquí puedes cambiar la música según la escena
        PlayMusicForScene(scene.name);
    }

    void PlayMusicForScene(string sceneName)
    {
        if (sceneName == "Nivel")
        {
            // Aquí establece la música para la escena 1
            audioSource.Stop();
        }
    }
}