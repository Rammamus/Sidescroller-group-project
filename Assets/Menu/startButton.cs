using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startButton : MonoBehaviour
{
    public int gameStartScene;
    // Build number of scene to start when start button is pressed
         void StartGame()
    {   
        SceneManager.LoadScene(gameStartScene);
    }   
}