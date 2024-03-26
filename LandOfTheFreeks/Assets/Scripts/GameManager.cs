using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] bossPrefabs;
    public GameObject collectibleSpawnerLincoln;
    public GameObject collectibleSpawnerTrump;

    void Start()
    {
        DeactivateAllSpawners();
        // Choose a random boss enemy
        int bossIndex = UnityEngine.Random.Range(0, bossPrefabs.Length);
        GameObject chosenBoss = Instantiate(bossPrefabs[bossIndex]);

        // Adjust collectibles based on the chosen boss
        AdjustCollectibles(chosenBoss);
    }

    void AdjustCollectibles(GameObject boss)
    {
        // Disable both spawners at first
       // DeactivateAllSpawners();

        // Example: Adjust collectibles based on boss type
        if (boss.name == "basic-boss(Clone)" || boss.name == "basic-boss")
        {
            Debug.Log("lincoln");
            // Enable collectible spawner for boss 1
            collectibleSpawnerLincoln.SetActive(true);

            // Disable collectible spawner for boss 2
            collectibleSpawnerTrump.SetActive(false);
        }
        else if (boss.name == "basic-boss 1(Clone)" || boss.name == "basic-boss 1")
        {
            Debug.Log("trump");
            // Enable collectible spawner for boss 2
            collectibleSpawnerTrump.SetActive(true);

            // Disable collectible spawner for boss 1
            collectibleSpawnerLincoln.SetActive(false);
        }
        // Add more conditions for other boss types if needed
    }

    // You may call this method from somewhere in your code to deactivate all collectible spawners
    void DeactivateAllSpawners()
    {
        collectibleSpawnerLincoln.SetActive(false);
        collectibleSpawnerTrump.SetActive(false);
        Debug.Log("turns 'off' both");

    }
}