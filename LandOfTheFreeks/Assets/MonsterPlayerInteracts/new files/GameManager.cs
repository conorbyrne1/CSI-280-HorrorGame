using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
            
    }

    private void OnDisable()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    public GameObject[] bossPrefabs;
    public GameObject collectibleSpawnerBiden;
    public GameObject collectibleSpawnerTrump;
    public GameObject collectibleSpawnerObama;
    public int bossNum;

    void Start()
    {
        DeactivateAllSpawners();
        // Choose a random boss enemy
        int bossIndex = UnityEngine.Random.Range(0, bossPrefabs.Length);
        GameObject chosenBoss = Instantiate(bossPrefabs[bossIndex]);

        // Adjust collectibles based on the chosen boss
        AdjustCollectibles(chosenBoss);
    }

    public int AdjustCollectibles(GameObject boss)
    {
        // Disable both spawners at first
       // DeactivateAllSpawners();

        // Example: Adjust collectibles based on boss type
        if (boss.name == "Biden(Clone)" || boss.name == "Biden")
        {
            Debug.Log("Biden");
            bossNum = 0;
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
            bossNum = 1;
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
            bossNum = 2;
            // Enable collectible spawner for boss 3
            collectibleSpawnerObama.SetActive(true);

            // Disable collectible spawner for boss 2
            collectibleSpawnerTrump.SetActive(false);

            // Disable collectible spawner for boss 1
            collectibleSpawnerBiden.SetActive(false);

        }
        return bossNum;
    }

    // You may call this method from somewhere in your code to deactivate all collectible spawners
    void DeactivateAllSpawners()
    {
        collectibleSpawnerBiden.SetActive(false);
        collectibleSpawnerTrump.SetActive(false);
        collectibleSpawnerObama.SetActive(false);
        Debug.Log("turns 'off' both");

    }

    public int getBoss()
    {
        return bossNum;
    }
}