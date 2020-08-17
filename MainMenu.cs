using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour
{
    
    //Onclick event function for PLAY button
    public void PlayGame()
    {
        //the GameScene comes after the mainmenu scene(in build order), hence the index is increased by 1
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Onclick event function for QUIT button
    public void QuitGame()
    {
        UnityEngine.Debug.Log("QUIT");
        Application.Quit();
    }

}
