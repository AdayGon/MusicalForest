using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PulsarObjeto : MonoBehaviour
{
    public string sceneName;
    public Canvas canvasSuperposicion;
    public GameObject fuenteSonido;
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = fuenteSonido.GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
        audioSource.Play();
    }

    private void OnMouseOver()
    {
        canvasSuperposicion.gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        canvasSuperposicion.gameObject.SetActive(false);
    }
}