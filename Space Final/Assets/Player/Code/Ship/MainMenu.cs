using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu: MonoBehaviour
{

    //Using the Scenemanager, I am able to reference which scene I want to be in/go to
    //Simply by using SceneManager we can just reference which scene we want to go to, making this process simple
    //When PlayGame is pressed then the game will load the MainScene which is the game scene
    public void PlayGame()
    {
        SceneManager.LoadScene("MainScene");
    }
    //When this button is pressed, the scene Menu is loaded
    public void ReturnToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    //To quit the game, simply creating another variable for QuitGame can allow for a recall on that execution whenever the quit button is pressed
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}