using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class loadNextScene : MonoBehaviour {

    private int nbScenes;
    public static bool heartActive = false;

    // Use this for initialization
    void Start () {
       
    }

    IEnumerator NextScene()
    {
        nbScenes = SceneManager.sceneCountInBuildSettings;

        yield return new WaitForSeconds(10.0f);

        if (SceneManager.GetActiveScene().buildIndex < nbScenes - 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        else
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    // Update is called once per frame
    void Update () {

        if (heartActive == true)
        {
            StartCoroutine(NextScene());
            heartActive = false;
        }
    }
}
