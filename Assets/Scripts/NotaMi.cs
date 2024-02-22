using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotaMi : MonoBehaviour
{
    public AudioClip sonido;  // Asigna el sonido que quieres reproducir desde el inspector.

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))  // 0 representa el botón izquierdo del mouse.
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    ReproducirSonidoObjeto();
                }
            }
        }
    }

    private void ReproducirSonidoObjeto()
    {
        if (sonido != null)
        {
            AudioSource.PlayClipAtPoint(sonido, transform.position);
        }
    }
}
