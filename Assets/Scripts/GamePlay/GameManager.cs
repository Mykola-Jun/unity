using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	private void Awake()
	{
		if (instance == null)
			instance = this;

		Time.timeScale = 1f;
		Time.fixedDeltaTime = 0.02f * Time.timeScale;
	}

	public void PlayerDied ()
	{
		StartCoroutine(GameOver());
	}

	IEnumerator GameOver ()
	{
		Time.timeScale = .3f;
		Time.fixedDeltaTime = 0.02f * Time.timeScale;

		yield return new WaitForSecondsRealtime(1.5f);

		SceneManager.LoadScene("GameOver");
	}

}
