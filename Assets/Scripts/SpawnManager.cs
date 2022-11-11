using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject horse;
    private float spawnRangeX = 10;
    private float spawnRangeZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",startDelay,spawnInterval);
        InvokeRepeating("SpawnHorse", 5, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    void SpawnHorse()
    {
        int choseNear = Random.Range(0, 2); // saðda mý solda mý seçen random
        int[] ints = { -30, 30 }; //saðda veya solda yer belirten array
        if (choseNear == 0)
        {
            Vector3 horsePosLeft = new Vector3(ints[0], 0, Random.Range(-spawnRangeZ, spawnRangeZ));
            Vector3 newRotationRight = new Vector3(0, 90, 0);
            transform.eulerAngles = newRotationRight;
            Instantiate(horse, horsePosLeft, transform.rotation);
        }
        else if (choseNear == 1)
        {
            Vector3 horsePosRight = new Vector3(ints[1], 0, Random.Range(-spawnRangeZ, spawnRangeZ));
            Vector3 newRotationLeft = new Vector3(0, -90, 0);
            transform.eulerAngles = newRotationLeft;
            Instantiate(horse, horsePosRight, transform.rotation);
        }

    }
}
