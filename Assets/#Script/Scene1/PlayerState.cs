using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour {

    Movement movement;
    [SerializeField] private GameObject onClear;
    [SerializeField] private GameObject onDie;

    [SerializeField] private GameObject ruby;
    [SerializeField] private GameObject sapphire;
    [SerializeField] private GameObject amethyst;
    [SerializeField] AudioSource audio;

    [SerializeField] AudioSource myAudio1;
    [SerializeField] AudioSource myAudio2;
    [SerializeField] AudioSource myAudio3;
    // Use this for initialization
    void Start () {
        movement = GetComponent<Movement>();
	}

    public void ClearEvent()
    {
        onClear.gameObject.SetActive(true);
    }

    public void DieEvent()
    {
        onDie.gameObject.SetActive(true);
    }

    public void ItemView(GameObject item)
    {
        item.SetActive(true);
    }

    public void sound()
    {
        myAudio1.Play();
    }

    public void sound2()
    {
        myAudio2.Play();
    }

    public void sound3()
    {
        myAudio3.Play();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.transform.tag == "Goal" )
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money" ) +  1);
            DataController.isGameClear = true;
            movement.playerAnimator.Play("Clear");

            if (col.transform.name == "rubyItem")
                ItemView(ruby);

            if (col.transform.name == "sapphireItem")
                ItemView(sapphire);

            if (col.transform.name == "amethystItem")
                ItemView(amethyst);
        }

        if (col.transform.tag == "Obstacle")
        {
            DataController.isDie = true;
            movement.playerAnimator.Play("IsDie");
        }
    }

}
