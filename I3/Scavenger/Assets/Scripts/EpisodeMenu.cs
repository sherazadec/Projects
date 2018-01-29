using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EpisodeMenu : MonoBehaviour
{

    public void StartEpisodeOne()
    {
        SceneManager.LoadScene("OpeningScene");
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
