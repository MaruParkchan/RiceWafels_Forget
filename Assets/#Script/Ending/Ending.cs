using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour {

    [SerializeField] private GameObject sonObject;

    public void SonView()
    {
        sonObject.SetActive(true);
    }

}
