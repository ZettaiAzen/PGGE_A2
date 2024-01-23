using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultiplayerMenuScript : MonoBehaviour
{
    AudioSource m_audioSource;
    [SerializeField] AudioClip[] m_audioClips;

    // Start is called before the first frame update
    void Start()
    {
        m_audioSource = GetComponent<AudioSource>();
    }
    IEnumerator playSound_LoadScene(string sceneName)
    {
        // playing sound
        m_audioSource.Play();
        // wait for audio source to finish playing
        yield return new WaitForSeconds(m_audioSource.clip.length);
        // load scene after
        SceneManager.LoadScene(sceneName);
    }
    public void OnClickMainMenu()
    {
        // loads the main menu scene
        StartCoroutine(playSound_LoadScene("Menu"));
    }
}
