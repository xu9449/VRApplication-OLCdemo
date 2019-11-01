using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    

    public void Triggerpressed()
    {
        StartCoroutine(LoadYourAsyncScene());
    }

    IEnumerator LoadYourAsyncScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("MenuScene");

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }

    public void SceneLoader(string scenename)
    {
        //SceneManager.LoadScene("MenuScene");
        Application.LoadLevel(scenename);
    }
}
