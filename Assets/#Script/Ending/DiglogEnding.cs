using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DiglogEnding : MonoBehaviour {

    [SerializeField] private GameObject clone;
    [SerializeField] private GameObject diglogGameObject;
    public Image image;
    public Sprite[] sprite;

    private void Awake()
    {
        image.sprite = sprite[Random.Range(0, sprite.Length)];
    }

    public void Btn_off()
    {
        this.gameObject.SetActive(false);
        clone.gameObject.SetActive(true);
    }

    public void Btn_on()
    {
        Debug.Log("아");
        diglogGameObject.gameObject.SetActive(true);
    }
}
