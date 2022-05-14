using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    [SerializeField] private float retryTime;
    [SerializeField] private string restartSceneName;

	void Start () {
        StartCoroutine("RetryAgain");
	}

    public void SceneRestart()
    {
        SceneManager.LoadScene(restartSceneName);
    }

    IEnumerator RetryAgain()
    {
        yield return new WaitForSeconds(retryTime);
        SceneRestart();
    }
}
