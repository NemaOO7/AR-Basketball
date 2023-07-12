using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuAudio : MonoBehaviour
{
    public AudioClip audioTrack; // The audio track to play
    private AudioSource audioSource; // Reference to the AudioSource component

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioTrack;
        audioSource.Play();
    }

    private void Update()
    {
        // Check if the current scene is not the main menu scene
        if (SceneManager.GetActiveScene().name != "MainMenuScene")
        {
            // Stop playing the audio track
            audioSource.Stop();
        }
    }
}
