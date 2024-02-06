using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScreen : MonoBehaviour
{
    public GameObject loadingPanel;
    public string Scene;

    public void LoadScene()
    {
        loadingPanel.SetActive(true);
        StartCoroutine(LoadYourAsyncScene());
    }
    //carga asincrona de la otra escena
    IEnumerator LoadYourAsyncScene()
    {

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(Scene);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        loadingPanel.SetActive(false);
    }
}
