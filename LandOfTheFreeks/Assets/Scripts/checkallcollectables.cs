using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkallcollectables : MonoBehaviour
{
    public GameObject BunkerUI;
    public CollectableCount count;
    public TMPro.TMP_Text uiText;

    // Start is called before the first frame update
    void Start()
    {
        bool gotallcollectibles = count.gotall;
        // BunkerUI = FindObjectOfType<BunkerUI>().gameObject;
        uiText = BunkerUI.GetComponentInChildren<TMPro.TMP_Text>();
        if(uiText == null)
        {
            Debug.Log("Empty Text error");
        }
        else
        {
            uiText.text = "Get all 3 Collectables First";
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(BunkerUI.activeSelf == true)
        {
            if(count.gotall == true)
            {
                uiText.text = "Who's the monster?";
            }
        }
    }
}
