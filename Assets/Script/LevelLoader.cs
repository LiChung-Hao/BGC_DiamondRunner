using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{
    int currentSceneIndex;

    public GameObject canvas1;
    public GameObject canvas2;

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }



    public void RestartScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void LoadOptionsScreen()
    {
        canvas1.SetActive(false);
        canvas2.SetActive(true);
        //SceneManager.LoadScene("OptionScene");
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void LoadYouLose()
    {
        SceneManager.LoadScene("Lose Screen");
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
