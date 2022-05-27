using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public GameObject HighScore, Score;
    public TextMeshProUGUI scoreDisplay;
    // Start is called before the first frame update
    void Start()
    {
        //Start with score 0
        PlayerPrefs.SetInt(GamePrefs.Score, 0);

        //Screen never goes to sleep
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        // if the game is played for the first time, we don't want to show the highscore in the main menu
        if (!PlayerPrefs.HasKey("GamePlayed"))
        {
            PlayerPrefs.SetInt("HighScore", 0);
            HighScore.SetActive(false);
            Score.SetActive(false);
            PlayerPrefs.SetInt("GamePlayed",1); 

        } else // if the game is played before, we want to show the highscore 
        {
            HighScore.SetActive(true);
            Score.SetActive(true);
            if (PlayerPrefs.GetInt("Score") < PlayerPrefs.GetInt("HighScore"))
            {
                scoreDisplay.text = PlayerPrefs.GetInt("HighScore").ToString();
            }
            else
            {
                scoreDisplay.text = PlayerPrefs.GetInt("Score").ToString();
            }
            
        }
    }
}
