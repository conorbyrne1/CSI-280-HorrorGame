using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunkerScript : MonoBehaviour
{
    public GameObject BunkerUI;
    public GameObject BunkerPrefab;
    // Start is called before the first frame update
    void Start()
    {
        BunkerUI = FindObjectOfType<BunkerUI>().gameObject;
        BunkerUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            BunkerUI.SetActive(true);
            Debug.Log("Player in the swag zone");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            BunkerUI.SetActive(false);
            Debug.Log("Player deies");
        }
    }
}
