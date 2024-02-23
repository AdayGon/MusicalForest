using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Heart : MonoBehaviour
{
    // Método para eliminar el corazón
    public void RemoveHeart()
    {
        gameObject.SetActive(false); // Desactivar el objeto del corazón
    }
}