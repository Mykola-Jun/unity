using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject PauseMenuUi;

    public GameObject TabSound;


    void Start()
    {
        GameIsPaused = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                ResumeFunction();
            }
            else
            {
                Pause();
            }
        }
    }
    //Resume GamePlay function
    public void ResumeFunction()
    {
        Instantiate(TabSound, transform.position, Quaternion.identity);
        PauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    //The pause function
    public void Pause()
    {
            Instantiate(TabSound, transform.position, Quaternion.identity);
            PauseMenuUi.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        
    }
    // Go to the main menu
    public void LoadMenu()
    {
        Instantiate(TabSound, transform.position, Quaternion.identity);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
    }
    // Quitting game
    public void Quit()
    {
        Instantiate(TabSound, transform.position, Quaternion.identity);
        Debug.Log("Quitting...");
        Application.Quit();
    }
}
