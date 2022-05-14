using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeOutLast : MonoBehaviour {

    private float values = 1.0f;
    [SerializeField] AudioSource audio;
    [SerializeField] GameObject clone;

    private bool isDownSound;
    private void Awake()
    {
        Invoke("GameFadeOut", 2.0f);
        Invoke("SceneChange", 4.5f);

    }

    private void Update()
    {
        Btn_VolumeDown();
    }

    public void GameFadeOut()
    {
        clone.gameObject.SetActive(true);
        isDownSound = true;
    }

    public void SceneChange()
    {
        SceneManager.LoadScene("Message");
    }

    public void Btn_VolumeDown()
    {
        if (isDownSound)
        {
            values -= Time.deltaTime;
            audio.volume = values;
        }
    }
}
