using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFrutas : MonoBehaviour
{
    public GameObject[] FrutaPrefabs;//Array animales

    public float spawnRangeX = 2; // Limites laterales
    public float spawnRangeY = 2; // Limites verticales

    public float startDelay = 2;
    public float spawnInterval = 1.5f;

    public int FrutaIndex; // Posicion de las Frutas en el Array

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomFruta", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S)) //pulsar S para que salga una fruta
        {
            SpawnRandomFruta();
        }
    }
    private void SpawnRandomFruta()
    {
        Vector2 spawnPos = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), spawnRangeY);
        int animalIndex = Random.Range(1, FrutaPrefabs.Length); // genera animalIndex en funcion del numero de Prefabs
        Instantiate(FrutaPrefabs[animalIndex], spawnPos, FrutaPrefabs[animalIndex].transform.rotation); //instancia un animal
    }
}
