using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float xRange = 11f;
    private float zRange = 130f;
    public float startDelay = 2f;
    public float intervalDelay = 0.5f;

    public GameObject[] animalPrefabs;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",startDelay,intervalDelay);
    }


    void Update()
    {
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 positionOfAnimal = new Vector3(Random.Range(xRange, -xRange), 0, zRange);
        Instantiate(animalPrefabs[animalIndex], positionOfAnimal, animalPrefabs[animalIndex].transform.rotation);
    }
}
