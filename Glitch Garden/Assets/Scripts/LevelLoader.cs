using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    int currentSceneIndex;
    [SerializeField] int waitInSeconds = 4;

    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            StartCoroutine(LoadTitle());
        }
 
    }

    IEnumerator LoadTitle()
    {
        yield return new WaitForSeconds(waitInSeconds);
        LoadNextScene();
        //SceneManager.LoadScene("Title Screen");
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex+1);
    }
}
