using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseButton : MonoBehaviour {

    public GameObject clone;

	public void PauseGame()
    {
        clone.SetActive(true);
        Time.timeScale = 0;
    }

    public void ExitGame()
    {
        clone.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene("Intro");
    }

    public void ResumeGame()
    {
        clone.SetActive(false);
        Time.timeScale = 1;
    }
}
