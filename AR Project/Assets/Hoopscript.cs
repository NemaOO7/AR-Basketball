using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
public class Hoopscript : MonoBehaviour
{
    public AudioClip bumpSound;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Hoop")){
            GetComponent<AudioSource>().PlayOneShot(bumpSound); 
        }
    }
}