 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CutScene1 : MonoBehaviour {

    [SerializeField] private string[] nextSceneName;
    [SerializeField] private GameObject[] textObject;

    private void Awake()
    {
        StartCoroutine(StartText());
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            NextChangeScene();
    }

    public void NextChangeScene()
    {
        if(IntroController.gameLevel == 1)
            SceneManager.LoadScene(nextSceneName[0]);

        if (IntroController.gameLevel == 2)
            SceneManager.LoadScene(nextSceneName[1]);

        if (IntroController.gameLevel == 3)
            SceneManager.LoadScene(nextSceneName[2]);
    }

    IEnumerator StartText()
    {
        textObject[0].SetActive(true);
        yield return new WaitForSeconds(5.0f);
        textObject[0].SetActive(false);
        textObject[1].SetActive(true);
    }


}
