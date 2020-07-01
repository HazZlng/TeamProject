using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public AudioSource levelMusic;

    public int score;
    public int scorex;

    public Text scoreText;
    public Text timeText;
    
    public float time;
    public float timer;

    public GameObject theGameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        levelMusic.volume = levelMusic.volume / 4f;
        scoreText.text = "Score : " + score;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timeText.text = "Time : " + (time + timer);

        if (time + timer < 0)
        {
            Time.timeScale = 0;
            levelMusic.Stop();
            theGameOverScreen.SetActive(true);
        }
    }

    
}
