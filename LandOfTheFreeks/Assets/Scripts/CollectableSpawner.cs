using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSpawner : MonoBehaviour
{
    public GameObject[] collectiblePrefabs; // Array of different collectible prefabs
    public Transform[] spawnPoints;
    public int numberOfItemsToSpawn = 3;

    void Start()
    {
        SpawnCollectibles();
    }

    void SpawnCollectibles()
    {
        // Shuffle the collectible prefabs array to ensure no duplicates
        ShuffleArray(collectiblePrefabs);
        // Make sure the number of items to spawn doesn't exceed the number of spawn points
        numberOfItemsToSpawn = Mathf.Min(numberOfItemsToSpawn, spawnPoints.Length);

        // Create a list to keep track of spawn points already used
        var usedSpawnPoints = new bool[spawnPoints.Length];

        for (int i = 0; i < numberOfItemsToSpawn; i++)
        {
            // Find a random spawn point that hasn't been used yet
            int randomIndex;
            do
            {
                randomIndex = Random.Range(0, spawnPoints.Length);
            } while (usedSpawnPoints[randomIndex]);

            // Mark the spawn point as used
            usedSpawnPoints[randomIndex] = true;

            //// Randomly select a collectible prefab
            //GameObject selectedPrefab = collectiblePrefabs[Random.Range(0, collectiblePrefabs.Length)];


            //// Instantiate the selected collectible at the chosen spawn point
            //Instantiate(selectedPrefab, spawnPoints[randomIndex].position, Quaternion.identity);

            Instantiate(collectiblePrefabs[i], spawnPoints[randomIndex].position, Quaternion.identity);
        }
    }

    void ShuffleArray(GameObject[] array)
    {
        // Fisher-Yates shuffle algorithm
        for (int i = array.Length - 1; i > 0; i--)
        {
            int randomIndex = Random.Range(0, i + 1);
            GameObject temp = array[randomIndex];
            array[randomIndex] = array[i];
            array[i] = temp;
        }
    }
}
