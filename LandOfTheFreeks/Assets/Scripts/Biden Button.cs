using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BidensButton : MonoBehaviour
{
    public GameObject BidenCollectable;
    public GameObject TrumpCollectable;
    public GameObject ObamaCollectable;

    int WhichBoss;

    // Start is called before the first frame update
    void Start()
    {
        if(BidenCollectable.activeSelf == true)
            WhichBoss = 0;
        else if(TrumpCollectable.activeSelf == true)
            WhichBoss = 1;
        else if(ObamaCollectable.activeSelf == true)
            WhichBoss= 2;
            
    }
    void OnButtonClick()
    { 
        if(WhichBoss == 0)
        {
            LoadScene("Victory");
        }
        else
        {
            LoadScene("Wrong Guess");
        }
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
