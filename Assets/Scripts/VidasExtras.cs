using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidasExtras : MonoBehaviour
{
    public int vidas = 3; // Número inicial de vidas
    public Image[] corazones; // Arreglo que contiene las imágenes de los corazones
    public Sprite corazonVacio; // Sprite que representa un corazón vacío
    public Sprite corazonLleno; // Sprite que representa un corazón lleno

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Limite"))
        {
            PerderVida(); // Llama a la función PerderVida()
            Destroy(gameObject); // Destruye la fruta
        }
    }

    void PerderVida()
    {
        vidas--; // Decrementa el número de vidas
        if (vidas >= 0)
        {
            corazones[vidas].sprite = corazonVacio; // Cambia el sprite del corazón correspondiente a vacío
        }

        if (vidas <= 0)
        {
            Debug.Log("Game Over"); // Si las vidas llegan a cero, muestra "Game Over" en la consola
            // Aquí podrías agregar más lógica para manejar el final del juego
        }
    }
}
