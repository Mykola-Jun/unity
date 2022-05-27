using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    public GameObject playButton;
    public GameObject HighScore, Score;
    public GameObject TabSound;
    public GameObject Loader;
    public Slider slider;
    public void StartPlay()
    {
        Instantiate(TabSound, transform.position, Quaternion.identity);
        playButton.SetActive(false);
        HighScore.SetActive(false);
        Score.SetActive(false);
        StartCoroutine(load());
    }
    IEnumerator load()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("GamePlay");
        Loader.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;

            yield return null;
        }
    }
}
