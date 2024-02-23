using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutBounds : MonoBehaviour
{
    public float topBound = 3; // limite superior de la escena
    public float lowerbound = -12; // limite inferior de la escena

    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > topBound) //si supera el limite superior
        {
           
        }
        else if (transform.position.y < lowerbound) // si supera el limite inferior
        {
            Destroy(gameObject); // Destruye el objeto

           
        }
    }
}
