using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    public GameObject thePauseScreen;

    private LevelManager theLevelManager;
    // Start is called before the first frame update
    void Start()
    {
        theLevelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PauseGame()
    {
        Time.timeScale = 0;

        thePauseScreen.SetActive(true);
        theLevelManager.levelMusic.Pause();
    }
    public void Resume()
    {
        thePauseScreen.SetActive(false);

        Time.timeScale = 1f;

        theLevelManager.levelMusic.Play();
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
