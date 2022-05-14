using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour {

    static public bool isGameStart = false;
    static public bool isDie = false;
    static public bool isGameClear = false;

    static public int easyNumber;
    static public int normalNumber;
    static public int normalCount;

    static public int itemNumber = 0;

    void Awake ()
    {
        isGameStart = false;
        isGameClear = false;
        isDie = false;
	}

}
