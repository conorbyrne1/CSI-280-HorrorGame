using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
                    
public class Collectable : MonoBehaviour
{
    public static event Action onCollected;
    public static int total;

    void Awake() => total++;

    // Update is called once per frame
    void Update()
    {
        //transform.localRotation = Quaternion.Euler(90f, Time.time * 100f, 0);
        transform.localRotation = Quaternion.Euler(0, Time.time * 100f, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            onCollected?.Invoke();
            Destroy(gameObject);
        }
    }
}
