using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllReset : MonoBehaviour {

    private void Awake()
    {
        DataController.easyNumber = 0;
        IntroController.gameLevel = 0;
        DataController.normalCount = 0;
        NormalDiglog.normalLevel1 = 0;
        NormalDiglog.normalLevel2 = 0;
        NormalDiglog.normalLevel3 = 0;
    }
}
