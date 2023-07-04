using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneswitcher : MonoBehaviour
{
    //switching from menu to help scene
    public void help()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    //switching scene from help to menu
    public void back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }
    //restarting the game
    public void RestartGame()
    {   //make sure scene is added to build setting
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    //exit the game
    public void quitgame()
    {
        Application.Quit();
    }
    //switching scene from menu to play scene
    public void playgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //back to menu from game scene
    public void menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}