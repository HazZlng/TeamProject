using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGame : MonoBehaviour
{
    public Sprite[] block_skin;
    public Image[] childeImage;
    Image block;
    // Use this for initialization
    void Start()
    {
        GetSkin();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetSkin()
    {
        for (int i = 0; i < 9; i++)
        {
            childeImage[i].sprite = block_skin[(Random.Range(0, 4))];
        }
    }

    public Sprite ReturnSkin(int i)
    {
        return childeImage[i].sprite;
    }
}
