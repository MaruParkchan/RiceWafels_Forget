using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MessageScene : MonoBehaviour {

	public void Btn_LICK()
    {
        Application.OpenURL("http://www.memozor.com/memory-tests/test-for-alzheimer-online");
    }

    public void Btn_Intro()
    {
        SceneManager.LoadScene("Intro");
    }
}
