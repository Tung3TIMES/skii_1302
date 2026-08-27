using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Start()
    {
        SceneManager.LoadSceneAsync("Scene01", LoadSceneMode.Additive);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Scene01");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
