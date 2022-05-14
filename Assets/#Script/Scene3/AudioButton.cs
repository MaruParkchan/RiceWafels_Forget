using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioButton : MonoBehaviour {

    static public bool isMusicPlay;
    public bool isNotPlay1;
    AudioSource audioSource;
    public AudioClip[] clip;
	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(AudioPlay());
        isMusicPlay = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator AudioPlay()
    {
        yield return new WaitForSeconds(1.0f);
        audioSource.clip = clip[0];
        audioSource.Play();
        yield return new WaitForSeconds(0.5f);
        if (isNotPlay1 != true)
        {
            audioSource.clip = clip[1];
            audioSource.Play();
        }
        yield return new WaitForSeconds(0.5f);
        audioSource.clip = clip[2];
        audioSource.Play();
        yield return new WaitForSeconds(0.5f);
        if (isNotPlay1 != true)
        {
            audioSource.clip = clip[3];
            audioSource.Play();
        }
        yield return new WaitForSeconds(0.5f);
        audioSource.clip = clip[4];
        audioSource.Play();
        yield return new WaitForSeconds(0.5f);
        audioSource.clip = clip[5];
        audioSource.Play();
        isMusicPlay = false;

    }
}
