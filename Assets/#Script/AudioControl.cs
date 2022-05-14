using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour {

    public float value;
    public bool isUp;
    public bool isDown;
    private AudioSource audio;
	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
        value = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
        audio.volume = value;

        if (isUp)
            VolumeUpSlow();
        if(isDown)
            VolumeDownSlow();

    }

    public void IsUp()
    {
        isUp = true;
    }
    
    public void IsDown()
    {
        isDown = true;
    }

    public void VolumeDownSlow()
    {
        if (value > 0.2f)
            value -= Time.deltaTime * 0.2f;
        else
        {
            value = 0.2f;
            isDown = false;
        }
    }

    public void VolumeUpSlow()
    {
        if (value >= 1.0f)
            isUp = false;

         value += Time.deltaTime * 0.2f;
    }

}
