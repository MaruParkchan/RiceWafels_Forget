using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroController : MonoBehaviour {

    [SerializeField] private string stageName; // easy , normal , hard -> 0 ,1 , 2 index
    [SerializeField] private Animator fadeAnimator;
    [SerializeField] private GameObject[] windowObject; // choice , howto , credit
    [SerializeField] private AudioSource audioSource;
    static public int gameLevel = 0;

    private void Awake()
    {
        gameLevel = 0;

        CloseAllWindow();
    }

    private void Update()
    {
        Debug.Log(DataController.itemNumber);
    }

    public void ButtonNextSScene()
    {
        SceneManager.LoadScene(stageName);
    }

    public void ButtonEazyMode()
    {
        gameLevel = 1;
    }

    public void ButtonNormalMode()
    {
        gameLevel = 2;
    }

    public void ButtonHardMode()
    {
        gameLevel = 3;
    }

    public void ButtonChoiceLevel()
    {
        windowObject[0].SetActive(true);
    }

    public void ButtonHowTo()
    {
        windowObject[1].SetActive(true);
    }

    public void ButtonCredit()
    {
        windowObject[2].SetActive(true);
    }

    public void ExitGameProject()
    {
        Application.Quit();
    }

    public void CloseAllWindow()
    {
        for(int i = 0; i < windowObject.Length; i++)
        {
            windowObject[i].SetActive(false);
        }
    }

    public void AllSound()
    {
        audioSource.Play();
    }

}
