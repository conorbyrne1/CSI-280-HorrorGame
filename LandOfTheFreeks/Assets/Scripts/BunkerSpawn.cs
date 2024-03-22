using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunkerSpawn : MonoBehaviour
{
    public GameObject bunkerPrefab;
    public Transform[] spawnPoints; // Assign your spawn points in the inspector

    void Start()
    {
        SpawnBunker();
    }

    void SpawnBunker()
    {
        // Choose a random spawn point index
        int spawnIndex = Random.Range(0, spawnPoints.Length);

        // Get the chosen spawn point
        Transform spawnPoint = spawnPoints[spawnIndex];

        // Instantiate the non-collectable object at the chosen spawn point
        Instantiate(bunkerPrefab, spawnPoint.position, Quaternion.identity);
    }
}
