using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LevelType
{
      Level1, Level2, Level3
}

public class NormalDiglog : MonoBehaviour {

    [SerializeField] private GameObject[] diglog;
    [SerializeField] private GameObject fatherClone;
    public LevelType levelType;
    static public int normalLevel1= 0;
    static public int normalLevel2 = 0;
    static public int normalLevel3 = 0;
    private int textIndex = 0;
    private int diglogIndex = 0;

    private void Awake()
    {
        this.gameObject.SetActive(true);

        switch(levelType)
        {
            case LevelType.Level1:
                diglog[normalLevel1].SetActive(true);
                break;

            case LevelType.Level2:
                diglog[normalLevel2].SetActive(true);
                break;

            case LevelType.Level3:
                diglog[normalLevel3].SetActive(true);
                break;
        }
    }

    public void OffDiglog()
    {
        if (AudioButton.isMusicPlay != true)
        {
            fatherClone.SetActive(false);
            DataController.isGameStart = true;
            this.gameObject.SetActive(false);
        }
    }
}
