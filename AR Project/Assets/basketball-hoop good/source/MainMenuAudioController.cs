using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class MainMenuAudioController : MonoBehaviour
{
    public AudioClip audioTrack; // The audio track to play

    private void Start()
    {
        // Check if the current scene is the main menu scene
        if (SceneManager.GetActiveScene().name == "StartScene")
        {
            // Play the audio track
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.clip = audioTrack;
            audioSource.Play();
        }
        else
        {
            // If the current scene is not the main menu scene, destroy this GameObject
            Destroy(gameObject);
        }
    }
}