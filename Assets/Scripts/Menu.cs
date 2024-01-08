using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    AudioSource m_audioSource;

    // Start is called before the first frame update
    void Start()
    {
        m_audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator playSound_LoadScene(string sceneName)
    {
        // playing sound
        Debug.Log("im making sound for " + sceneName);
        m_audioSource.Play();
        // wait for audio source to finish playing
        yield return new WaitForSeconds(m_audioSource.clip.length);
        // load scene after
        SceneManager.LoadScene(sceneName);
    }

    public void OnClickSinglePlayer()
    {
        //Debug.Log("Loading singleplayer game")
        StartCoroutine(playSound_LoadScene("SinglePlayer"));

    }

    public void OnClickMultiPlayer()
    {
        //Debug.Log("Loading multiplayer game");
        StartCoroutine(playSound_LoadScene("Multiplayer_Launcher"));

    }
    

}
