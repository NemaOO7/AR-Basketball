using UnityEngine;

public class HoopCollision : MonoBehaviour
{
    public AudioClip bumpSound;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball2"))
        {
            // Play the bump sound
            audioSource.PlayOneShot(bumpSound);
        }
    }
}