using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidasextras : MonoBehaviour
{
    public AudioSource mordisco;//Elegir el sonido del efecto


    // Start is called before the first frame update
    private void OntriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
