using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideButton : MonoBehaviour
{
    public GameObject BunkerUI;
    public CollectableCount count;
    public GameObject buttons;

    // Start is called before the first frame update
    void Start()
    {
        bool gotallcollectibles = count.gotall;

        buttons.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (BunkerUI.activeSelf == true)
        {
            if (count.gotall == true)
            {
                buttons.SetActive(true);
            }
        }
    }
}
