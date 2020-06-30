using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonScripts : MonoBehaviour
{
    public GameObject button;

    private LevelManager theLevelManager;

    public Sprite bonobono;

    private MainGame theMainGame;

    // Start is called before the first frame update
    void Start()
    {
        theLevelManager = FindObjectOfType<LevelManager>();
        theMainGame = FindObjectOfType<MainGame>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickAnswer()
    {
        int num = button.GetComponent<GetButton>().buttoncount;
        Sprite spriteImage = button.GetComponent<GetButton>().ReturnSprite(num);

        if (this.gameObject.GetComponent<Image>().sprite.name == spriteImage.name)
        {
            theMainGame.childeImage[num].sprite = bonobono;
            button.GetComponent<GetButton>().buttoncount += 1;
            if (button.GetComponent<GetButton>().buttoncount == 9)
            {
                button.GetComponent<GetButton>().buttoncount = 0;
                button.GetComponent<GetButton>().ChangeImage();
                theLevelManager.score += theLevelManager.scorex;
                theLevelManager.scorex = theLevelManager.scorex * 2;
            }
            
        }

        if (this.gameObject.GetComponent<Image>().sprite.name != spriteImage.name)
        {
            button.GetComponent<GetButton>().buttoncount = 0;
            button.GetComponent<GetButton>().ChangeImage();
            if(theLevelManager.score > 0)
            {
                theLevelManager.score -= 1;
                theLevelManager.scorex = 2;
            }
        }
        theLevelManager.scoreText.text = "Score : " + theLevelManager.score;
    }
}

