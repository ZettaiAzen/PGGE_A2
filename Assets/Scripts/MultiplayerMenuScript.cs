using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultiplayerMenuScript : MonoBehaviour
{
    public void OnClickMainMenu()
    {
        // loads the main menu scene
        SceneManager.LoadScene("Menu");
    }
}
