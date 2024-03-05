using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recordprebaf : MonoBehaviour
{
    public GameObject prefabToRecord; // The prefab whose positions you want to record

    void Start()
    {
        RecordPositions();
    }

    void RecordPositions()
    {
        // Find all instances of the prefab in the scene
        GameObject[] prefabs = GameObject.FindGameObjectsWithTag(prefabToRecord.tag);

        // Create empty GameObjects at the same positions and copy their rotations
        foreach (GameObject prefab in prefabs)
        {
            GameObject emptyObject = new GameObject("SpawnPoint");
            emptyObject.transform.position = prefab.transform.position;
            emptyObject.transform.rotation = prefab.transform.rotation;
        }
    }
}
