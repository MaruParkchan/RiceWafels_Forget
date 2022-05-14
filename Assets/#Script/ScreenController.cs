using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenController : MonoBehaviour {

    [RuntimeInitializeOnLoadMethod]

    private void Awake()
    {
        Screen.SetResolution(Screen.width, (Screen.width / 9) * 16, true);
    }
}
