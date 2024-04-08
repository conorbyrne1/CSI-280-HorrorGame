using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunkerUI : MonoBehaviour
{
    public CollectableCount count;
    
    // Start is called before the first frame update
    void Start()
    {
       bool gotallcollectibles = count.gotall;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
