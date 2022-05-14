using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour {

    [SerializeField] private float fadeInTimer = 0;
    [SerializeField] private Image fadeImage;
    private bool isDiglogOn;

    [SerializeField] private GameObject diglogObject;
    [SerializeField] private float diglogViewTimer = 0;
    private float alphaValue;
    void Start ()
    {
        diglogObject.SetActive(false);
        isDiglogOn = false;
        alphaValue = 255f;
    }
	
	void Update () {
        FadeAlphaChange();
    }

    void FadeAlphaChange()
    {
        if (alphaValue < 0)
        {
            alphaValue = 0;

            if (isDiglogOn != true)
            {
               StartCoroutine("DiglogView");
                isDiglogOn = true;
            }       
            return;
        }

        alphaValue -= Time.deltaTime * fadeInTimer;
        fadeImage.color = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, alphaValue/255f);
    }

    IEnumerator DiglogView()
    {
        yield return new WaitForSeconds(diglogViewTimer);
        diglogObject.SetActive(true);
    }
}
