using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetButton : MonoBehaviour
{
    public GameObject obj;
    public int buttoncount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Sprite ReturnSprite(int count)
    {
        return obj.GetComponent<MainGame>().ReturnSkin(count);
    }

    public void ChangeImage()
    {
        obj.GetComponent<MainGame>().GetSkin();
    }
}
