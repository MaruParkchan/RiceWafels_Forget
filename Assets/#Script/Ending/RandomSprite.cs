using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSprite : MonoBehaviour {

    public Sprite[] sprite;
    private Image image;
	
	void Awake ()
    {
        image = GetComponent<Image>();
        image.sprite = sprite[Random.Range(0, sprite.Length)];
	}
	
}
