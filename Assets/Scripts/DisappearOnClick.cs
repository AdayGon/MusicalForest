using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearOnClick : MonoBehaviour
{
    private AudioSource audioSource;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
            // Detectar clic izquierdo del ratón
            if (Input.GetMouseButtonUp(0))
            {
                // Convertir posición del ratón a coordenadas del mundo
                Vector2 clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                // Detectar si el clic del ratón está encima de este objeto
                Collider2D hitCollider = Physics2D.OverlapPoint(clickPos);
                if (hitCollider != null && hitCollider.gameObject == gameObject)
                {
                    // Ocultar el objeto
                    gameObject.SetActive(false);
                    audioSource.Play();


            }
            }
        
    }
}
