using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCount : MonoBehaviour
{
    TMPro.TMP_Text text;
    int count;
    public int total;
    public bool gotall = false;

    private void Awake()
    {
        text = GetComponent<TMPro.TMP_Text>();
    }

    void Start() => UpdateCount();
    void OnEnable() => Collectable.onCollected += OnCollectableCollected;
    void OnDisable() => Collectable.onCollected -= OnCollectableCollected;

    void OnCollectableCollected()
    {
        count++;
        UpdateCount();
    }

    void UpdateCount()
    {
        text.text = $"Items Collected: {count} / {total}";
        if (count == total)
            gotall = true;
    }
}
