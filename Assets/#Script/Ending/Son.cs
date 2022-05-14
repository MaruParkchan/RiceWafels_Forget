using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Son : MonoBehaviour {

    [SerializeField] private float timer;
    [SerializeField] GameObject view;
	// Use this for initialization
	void Start () {
        StartCoroutine(startView());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator startView()
    {
        yield return new WaitForSeconds(timer);
        view.SetActive(true);
    }
}
