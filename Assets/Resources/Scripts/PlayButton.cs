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

    private void OnMouseOver()
    {
        //audioSource.PlayOneShot(mySound);

    }


    public void PlayGame()
    {
        audioSource.Play();
        SceneManager.LoadScene(1);
    }
}
