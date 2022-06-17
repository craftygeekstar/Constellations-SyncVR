using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControls : MonoBehaviour
{
    /*
        This script contains the basic functions for menu buttons.
    */
    public void StartGame(int level)
    {
        SceneManager.LoadScene(1);
    }

    public void QuitApplication()
    {
        Application.Quit();
        Debug.Log("app has been quit");
    }

    public void MainMenu(int level)
    {
        SceneManager.LoadScene(0);
    }
}
