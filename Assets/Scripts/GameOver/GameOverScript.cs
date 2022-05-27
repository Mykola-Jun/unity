using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public TextMeshProUGUI scoreDisplay;

    public GameObject NewHighScore;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("Score") > PlayerPrefs.GetInt("HighScore"))
        {
            NewHighScore.SetActive(true);
            PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("Score"));
        }
        else
        {
            NewHighScore.SetActive(false);
        }
        int score = PlayerPrefs.GetInt("Score");
        
        scoreDisplay.text = score.ToString();
    }
    private void Update()
    {
        // program the start again and main menu buttons
    }

}
