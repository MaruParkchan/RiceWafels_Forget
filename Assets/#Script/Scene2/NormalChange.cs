using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NormalChange : MonoBehaviour
{
    [SerializeField] NormalDiglog normalDiglog;
    [SerializeField] private float changeTime;


    void Start()
    {
        StartCoroutine("RetryAgain");
    }

    public void SceneRestart()
    {

    }

    IEnumerator RetryAgain()
    {
        yield return new WaitForSeconds(changeTime);
        SceneChange();
    }

    void SceneChange()
    {
        Debug.Log("시작");
        DataController.normalCount++;

        if (DataController.normalCount == 1)
        {
            NormalDiglog.normalLevel1++;
            SceneManager.LoadScene("Scene05"); // 2
        }

        if (DataController.normalCount == 2)
        {
            NormalDiglog.normalLevel2++;
            SceneManager.LoadScene("Scene06");  // 3
        }

        if (DataController.normalCount == 3)
        {
            NormalDiglog.normalLevel3++;
            SceneManager.LoadScene("Scene04"); // 1
        }
        ////////////////////////////////////
        if (DataController.normalCount == 4)
        {
            NormalDiglog.normalLevel1++;
            SceneManager.LoadScene("Scene06"); // 3
        }

        if (DataController.normalCount == 5)
        {
            NormalDiglog.normalLevel3++;
            SceneManager.LoadScene("Scene05");// 2
        }
        if (DataController.normalCount == 6)
        {
            NormalDiglog.normalLevel2++;
            SceneManager.LoadScene("Scene06");//3
        }
        ////////////////////////////////////
        if (DataController.normalCount == 7)
        {
            NormalDiglog.normalLevel3++;
            SceneManager.LoadScene("Scene04");//1
        }

        if (DataController.normalCount == 8)
        {
            NormalDiglog.normalLevel1++;
            SceneManager.LoadScene("Scene05");//2
        }

        if (DataController.normalCount == 9)
        {
            NormalDiglog.normalLevel2++;
            SceneManager.LoadScene("Scene04");//1
        }
        ////////////////////////////////////
        if (DataController.normalCount == 10)
        {
            NormalDiglog.normalLevel1++;
            SceneManager.LoadScene("Scene06");//3
        }

        if (DataController.normalCount == 11)
        {
            NormalDiglog.normalLevel3++;
            SceneManager.LoadScene("Scene05");//2
        }

        if (DataController.normalCount == 12) // Ending
        {
            DataController.normalCount = 0;
            SceneManager.LoadScene("Ending");
        }
    }
}
