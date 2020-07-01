//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject thePauseScreen;
    private GameManager GM;

    private void Start()
    {
        GM = FindObjectOfType<GameManager>();
    }
    public void PauseGame()
    {
        Time.timeScale = 0;

        thePauseScreen.SetActive(true);
        GM.GMusic.Pause();
    }
    public void Resume()
    {
        GM.GMusic.Play();
        thePauseScreen.SetActive(false);
        Time.timeScale = 1f;
    }
    public void GetOut()
    {
        SceneManager.LoadScene("Lobby");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
}
