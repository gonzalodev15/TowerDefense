using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFlow : MonoBehaviour
{
    public string retryLevelName;

    public void LoadLevel(string levelName)
    {
        SceneManager.LoadSceneAsync(levelName);
    }

    public void RetryLevel()
    {
        SceneManager.LoadSceneAsync(retryLevelName);
    }
}
