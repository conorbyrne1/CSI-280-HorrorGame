using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject collectibleSpawnerBiden;
    public GameObject collectibleSpawnerTrump;
    public GameObject collectibleSpawnerObama;

    public GameObject BidenButton;

    bool BidenActive;
    bool TrumpActive;
    bool ObamaActive;

    // Start is called before the first frame update
    void Start()
    {
        if (collectibleSpawnerBiden.activeSelf == true)
        {
            BidenActive = true;
            TrumpActive = false;
            ObamaActive = false;
        }
        else if(collectibleSpawnerTrump.activeSelf == true)
        {
            TrumpActive = true;
            BidenActive = false;
            ObamaActive = false;
        }
        else if (collectibleSpawnerObama.activeSelf == true)
        {
            ObamaActive = true;
            TrumpActive = false;
            BidenActive = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    
}
