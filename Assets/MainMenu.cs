using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour

{
    public void LoadLevel(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    // public void ChangeScene()
    // {
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    // }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
