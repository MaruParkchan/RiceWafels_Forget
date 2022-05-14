using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NormalFather : MonoBehaviour {

    [SerializeField] private Sprite[] sprite;
    private int index;
    Image image;
	// Use this for initialization
	void Awake () {
        if (DataController.normalCount >= 9)
            image.sprite = sprite[2];


        else if (DataController.normalCount >= 6)
            image.sprite = sprite[1];


        else if (DataController.normalCount >= 3)
            image.sprite = sprite[0];

    }
}
