using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class EndMenu : MonoBehaviour
{
    //Onclick event function for RESTART button
    public void RestartGame()
    {
        //the GameScene comes before the endmenu scene(in build order), hence the index is decreased by 1
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }

    //Onclick event function for MAINMENU button
    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    //Onclick event function for QUIT button
    public void QuitGame()
    {
        UnityEngine.Debug.Log("QUIT");
        Application.Quit();
    }
}
