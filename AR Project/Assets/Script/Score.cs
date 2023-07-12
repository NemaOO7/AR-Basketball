using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
public class Score : MonoBehaviour
{
    public float score = 0f; // Starting score
    public float highscore = 0f;
    public TextMeshProUGUI scoreText; // Reference to the UI text object that displays the score
    public TextMeshProUGUI highscoreText;
    
    public GameObject effectObject;
    public float maxMissedShots = 3f;
    private float missedShots =0f;
    public AudioClip scoreSound;
    public AudioClip bumpSound; 
    public AudioClip miss;
  

    void Start()
    {
        highscore = PlayerPrefs.GetFloat("highscore", 0);
        highscoreText.text = "HIGHSCORE: "+ highscore.ToString(); 
        PlayerPrefs.SetString("FinalScore","0");
    }
    // This function is called when the score object collides with the Ball1 object

     
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball2"))
        {
            score =score +0.5f; // Increase score by 1
            GetComponent<ParticleSystem>().Play();
            GetComponent<AudioSource>().PlayOneShot(scoreSound);
            UpdateScoreText(); // Update the score text in the UI
            
        }
        else if(other.gameObject.CompareTag("Ground")){
            missedShots = missedShots +0.5f;
            if(missedShots>=maxMissedShots){

              SceneManager.LoadScene("GameOverScene");

              
            }
            
        }

        PlayerPrefs.SetString("FinalScore",scoreText.text);
                PlayerPrefs.Save();
    }

    // This function updates the score text in the UI
    public void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString(); // Update the score text with the new score value
            
            if(highscore < score)
           PlayerPrefs.SetFloat("highscore", score); 
        }
    }

   
    
}