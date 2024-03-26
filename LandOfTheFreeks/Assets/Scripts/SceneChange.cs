using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    //public Scene scene;
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
