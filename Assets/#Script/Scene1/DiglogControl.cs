using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiglogControl : MonoBehaviour {

    [SerializeField] private GameObject[] diglog;
    [SerializeField] private GameObject fatherImage;

    private int textIndex = 0;
    private int diglogIndex = 0;

    private void Awake()
    {
        this.gameObject.SetActive(true);
        diglog[DataController.easyNumber].SetActive(true);
    }

    public void OffDiglog()
    {
        if (AudioButton.isMusicPlay != true)
        {
            fatherImage.SetActive(false);
            DataController.isGameStart = true;
            this.gameObject.SetActive(false);
        }
    }
}
