using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public PatternMaker pm;
    public GameObject theGameOverScreen;
    public AudioSource Music;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI stageText;

    public int score;
    public int Difficulty;
    float sec;
    public bool result;
    // Start is called before the first frame update
    void Start()
    {
        Difficulty = 2;
        score = 0;
        sec = 1.0f;

        Music.Play();
        pm = FindObjectOfType<PatternMaker>();
        CallPatternMaker();
    }

    private void Update()
    {
        scoreText.text = "Score : " + score;
        stageText.text = "Stage : " + Difficulty;
    }
    void SetDifficulty()
    {
        Difficulty++;
    }

    void CallPatternMaker()
    {
        SetDifficulty();
        StartCoroutine(pm.WaitFor2Sec(sec, Difficulty));
    }

    public void CallScoring()
    {
        result = pm.ScoringOn(Difficulty);
        if (!result)
        {
            Time.timeScale = 0;
            Music.Stop();
            theGameOverScreen.SetActive(true);
        }
        else
        {
            score += 10 * Difficulty;

            if (sec == 0.5f)
                sec = 0.5f;
            else
                sec -= 0.1f;

            pm.SetBlank();
            pm.POC.RayList.Clear();
            pm.RandomList.Clear();
            CallPatternMaker();
        }
    }
}
