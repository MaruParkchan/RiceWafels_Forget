using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HardChange : MonoBehaviour {

    [SerializeField] private float changeTime;
    [SerializeField] private string nextScene;

    void Start () {
         StartCoroutine("RetryAgain");
 
    }

    IEnumerator RetryAgain()
    {
        yield return new WaitForSeconds(changeTime);
        NextScene();
    }

    public void NextScene()
    {
        SceneManager.LoadScene(nextScene);
    }
}
