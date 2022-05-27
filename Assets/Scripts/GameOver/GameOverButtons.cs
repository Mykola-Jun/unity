using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour
{
    public GameObject tabSound;

    public void MainMenu()
    {
        Instantiate(tabSound,transform.position, Quaternion.identity);
        SceneManager.LoadScene("Main");
    }
    public void Quit()
    {
        Instantiate(tabSound, transform.position, Quaternion.identity);
        Debug.Log("Quitting...");
        Application.Quit(); 
    }
}
