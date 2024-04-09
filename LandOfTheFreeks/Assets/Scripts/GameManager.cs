using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] bossPrefabs;
    public GameObject collectibleSpawnerBiden;
    public GameObject collectibleSpawnerTrump;
    public GameObject collectibleSpawnerObama;

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
        if (boss.name == "Biden(Clone)" || boss.name == "Biden")
        {
            Debug.Log("Biden");
            // Enable collectible spawner for boss 1
            collectibleSpawnerBiden.SetActive(true);

            // Disable collectible spawner for boss 2
            collectibleSpawnerTrump.SetActive(false);

            // Disable collectible spawner for boss 3
            collectibleSpawnerObama.SetActive(false);
        }
        else if (boss.name == "Trump(Clone)" || boss.name == "Trump")
        {
            Debug.Log("trump");
            // Enable collectible spawner for boss 2
            collectibleSpawnerTrump.SetActive(true);

            // Disable collectible spawner for boss 1
            collectibleSpawnerBiden.SetActive(false);

            // Disable collectible spawner for boss 3
            collectibleSpawnerObama.SetActive(false);
        }
        // Add more conditions for other boss types if needed

        else if (boss.name == "Obama(Clone)" || boss.name == "Obama")
        {
            Debug.Log("obama");
            // Enable collectible spawner for boss 3
            collectibleSpawnerObama.SetActive(true);

            // Disable collectible spawner for boss 2
            collectibleSpawnerTrump.SetActive(false);

            // Disable collectible spawner for boss 1
            collectibleSpawnerBiden.SetActive(false);

            
        }
    }

    // You may call this method from somewhere in your code to deactivate all collectible spawners
    void DeactivateAllSpawners()
    {
        collectibleSpawnerBiden.SetActive(false);
        collectibleSpawnerTrump.SetActive(false);
        collectibleSpawnerObama.SetActive(false);
        Debug.Log("turns 'off' both");

    }
}