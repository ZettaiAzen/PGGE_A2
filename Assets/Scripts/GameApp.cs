using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PGGE.Patterns;
using UnityEngine.SceneManagement;

public class GameApp : Singleton<GameApp>
{
    // changed bool to starting with lowercase since its a variable not a constant
    public bool gamePaused;

    void Start()
    {
        gamePaused = false;
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            PauseGame();
        }
    }

    // changed pausing into a function
    public void PauseGame()
    {
        // changes the variable of gamePaused to the opposite
        gamePaused = !gamePaused;
        // sets the timescale to 0 if game is paused and 1 if game is not paused
        Time.timeScale = gamePaused ? 0 : 1;
    }

    // called first
    void OnEnable()
    {
        Debug.Log("OnEnable called");
        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.sceneLoaded += OnSceneLoaded2;
    }

    // called when the game terminates
    void OnDisable()
    {
        Debug.Log("OnDisable");
        SceneManager.sceneLoaded -= OnSceneLoaded2;
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("OnSceneLoaded - Scene Index: " + scene.buildIndex + " Scene Name: " + scene.name);
        //Debug.Log(mode);
    }

    void OnSceneLoaded2(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Hello. Welocome to my scene.");
    }
}
