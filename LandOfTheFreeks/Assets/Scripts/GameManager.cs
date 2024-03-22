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
        // Choose a random boss enemy
        int bossIndex = Random.Range(0, bossPrefabs.Length);
        GameObject chosenBoss = Instantiate(bossPrefabs[bossIndex]);

        // Adjust collectibles based on the chosen boss
        AdjustCollectibles(chosenBoss);
    }

    void AdjustCollectibles(GameObject boss)
    {
        // Disable both spawners at first
        collectibleSpawnerLincoln.SetActive(false);
        collectibleSpawnerTrump.SetActive(false);

        // Example: Adjust collectibles based on boss type
        if (boss.name == "basic-boss")
        {
            // Adjust collectibles for boss 1
            // Example: Disable some collectibles or spawn specific collectibles

            // Enable collectible spawner for boss 1
            collectibleSpawnerLincoln.SetActive(true);

        }
        else if (boss.name == "basic-boss 1")
        {

            // Adjust collectibles for boss 2
            // Enable collectible spawner for boss 2
            collectibleSpawnerTrump.SetActive(true);

        }
        // Add more conditions for other boss types if needed
    }

    void ActivateCollectibleSpawners(GameObject[] spawners)
    {
        foreach (GameObject spawner in spawners)
        {
            spawner.SetActive(true);
        }
    }
}