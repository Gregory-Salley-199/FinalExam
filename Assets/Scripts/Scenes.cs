using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("3Game");
    }

    public void StopPlaying()
    {
        SceneManager.LoadScene("4Exit");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("1Intro");
    }

    public void NextButton()
    {
        SceneManager.LoadScene("2HighScores");
    }

    public void ExitGame()
    {
        // exit the game for real play
        //Application.Quit();
        //does not work in Unity since it would  lose all settings. so:
        UnityEditor.EditorApplication.isPlaying = false;
    }
}