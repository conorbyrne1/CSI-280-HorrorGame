using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    public void BidenButtonPressed()
    {
        if (GameManager.Instance.bossNum == 0)
        {
            LoadScene("Victory");
        }
        else
        {
            LoadScene("Wrong Guess");
        }
    }

    public void TrumpButtonPressed()
    {
        if (GameManager.Instance.bossNum == 1)
        {
            LoadScene("Victory");
        }
        else
        {
            LoadScene("Wrong Guess");
        }
    }

    public void ObamaButtonPressed()
    {
        if (GameManager.Instance.bossNum == 2)
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

