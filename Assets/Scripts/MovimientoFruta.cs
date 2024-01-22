using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFruta : MonoBehaviour
{
    public float speed = 6; //Velocidad
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
    }
}
