using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    public GameObject Fscore;
    public TextMeshProUGUI fscoreText;

    void Start()
    {
        fscoreText= Fscore.GetComponent<TextMeshProUGUI>();
        fscoreText.text = PlayerPrefs.GetString("FinalScore");
    }
    
    public void RetryGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ReturnToHome()
    {
        SceneManager.LoadScene(0);
    }
}
