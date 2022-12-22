using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewLevel : MonoBehaviour
{
    void LoadNextLevel()
    {
        int getSceneNum = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = getSceneNum + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);
        //poziom zaliczony, ładowanie kolejnego poziomu
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "NextLevel") 
        {
            LoadNextLevel();
        }
    }
}
