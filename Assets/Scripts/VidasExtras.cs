using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidasExtras : MonoBehaviour
{
    public int vidas = 3; // N�mero inicial de vidas
    public Image[] corazones; // Arreglo que contiene las im�genes de los corazones
    public Sprite corazonVacio; // Sprite que representa un coraz�n vac�o
    public Sprite corazonLleno; // Sprite que representa un coraz�n lleno

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Limite"))
        {
            PerderVida(); // Llama a la funci�n PerderVida()
            Destroy(gameObject); // Destruye la fruta
        }
    }

    void PerderVida()
    {
        vidas--; // Decrementa el n�mero de vidas
        if (vidas >= 0)
        {
            corazones[vidas].sprite = corazonVacio; // Cambia el sprite del coraz�n correspondiente a vac�o
        }

        if (vidas <= 0)
        {
            Debug.Log("Game Over"); // Si las vidas llegan a cero, muestra "Game Over" en la consola
            // Aqu� podr�as agregar m�s l�gica para manejar el final del juego
        }
    }
}
