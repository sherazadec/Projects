using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    public void NewGame()
    {
        SceneManager.LoadScene("ChooseEpisode");
    }

    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void BackGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Return()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
