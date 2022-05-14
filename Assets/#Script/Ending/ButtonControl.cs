using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour {

    private int index = -1;
    public GameObject[] command;
    private bool isOn;
    private bool isLock;

    public GameObject[] viewObject;
    public GameObject clone; 

    private void Update()
    {
        ViewObject();
        Debug.Log(index);
        StartCoun();

        if (isOn && isLock != true)
        {
            StartCoroutine(startNext());
            isLock = true;
            isOn = false;
        }
    }

    public void btnClick()
    {
        if(index <= 2)
          index++;
    }

    public void ViewObject()
    {
        if (index == 0)
            command[0].SetActive(true);

        if (index == 1)
            command[1].SetActive(true);

        if (index == 2)
            command[2].SetActive(true);

        if (index == 3)
            command[3].SetActive(true);


    }
    void StartCoun()
    {
        if (index >= 3)
        {
            isOn = true;
        }
    }

    IEnumerator startNext()
    {
        yield return new WaitForSeconds(1.5f);
        viewObject[0].SetActive(false);
        viewObject[1].SetActive(false);
        clone.gameObject.SetActive(true);
    }

}
