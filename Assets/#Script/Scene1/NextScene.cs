using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour {

    [SerializeField] private float changeTime;
    [SerializeField] private string loopSceneName;
    [SerializeField] private string nextScene;

    void Start()
    {
        StartCoroutine("RetryAgain");
    }

    public void SceneRestart()
    {
        if (DataController.easyNumber < 3)
        {
            DataController.easyNumber++;
            SceneManager.LoadScene(loopSceneName);
        }
        else
        {
            DataController.easyNumber = 0;
            SceneManager.LoadScene(nextScene);
        }
    }

    IEnumerator RetryAgain()
    {
        yield return new WaitForSeconds(changeTime);
          SceneRestart();
    }
}
