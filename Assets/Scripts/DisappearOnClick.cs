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
            // Detectar clic izquierdo del rat�n
            if (Input.GetMouseButtonUp(0))
            {
                // Convertir posici�n del rat�n a coordenadas del mundo
                Vector2 clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

                // Detectar si el clic del rat�n est� encima de este objeto
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
