//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManagerS : MonoBehaviour
{
    public GameObject thePauseScreen;
    private GamePlay GP;

    private void Start()
    {
        GP = FindObjectOfType<GamePlay>();
    }
    public void PauseGame()
    {
        Time.timeScale = 0;

        thePauseScreen.SetActive(true);
        GP.ThemeSound.Pause();
    }
    public void Resume()
    {
        GP.ThemeSound.Play();
        thePauseScreen.SetActive(false);
        Time.timeScale = 1f;

    }
    public void GetOut()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Lobby");
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
