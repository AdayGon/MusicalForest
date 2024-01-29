using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidadMovimiento = 5f;

    private void Update()
    {
        // Verificar si se ha hecho clic en la pantalla
        if (Input.GetMouseButtonDown(0))
        {
            // Obtener la posición del clic en la pantalla
            Vector3 posicionClic = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Mantener la misma Z que el personaje (2D)
            posicionClic.z = transform.position.z;

            // Realizar un raycast en 2D
            RaycastHit2D hit = Physics2D.Raycast(posicionClic, Vector2.zero);

            // Verificar si el raycast ha impactado y si el objeto impactado tiene el tag "Nivel"
            if (hit.collider != null && hit.collider.CompareTag("Nivel"))
            {
                // Mover el personaje directamente al punto del nivel
                MoverHaciaObjetivo(hit.collider.transform.position);
            }
        }
    }

    void MoverHaciaObjetivo(Vector3 destino)
    {
        // Mover al personaje directamente al destino
        transform.position = destino;

        // Puedes agregar aquí cualquier lógica adicional cuando el personaje llega al destino
        Debug.Log("Personaje ha llegado al destino");
    }
}


