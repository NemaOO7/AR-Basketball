using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;
using TMPro;

public class highscorescreen : MonoBehaviour
{
    public GameObject Hsvalue;
    public TextMeshProUGUI hsvalueText;

    void Start()
    {
        hsvalueText= Hsvalue.GetComponent<TextMeshProUGUI>();
        hsvalueText.text = PlayerPrefs.GetFloat("highscore",0).ToString();
    }

}
