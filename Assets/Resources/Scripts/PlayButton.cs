using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip mySound;

    void Start()
    {
        audioSource.GetComponent<AudioSource>();
    }
    void OnMouseEnter()
    {
        //audioSource.PlayOneShot(mySound);
        audioSource.Play();
    }

    public void PlayGame()
    {
        audioSource.Play();
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        audioSource.Play();
        SceneManager.LoadScene(0);
    }
}
