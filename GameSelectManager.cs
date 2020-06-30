using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSelectManager : MonoBehaviour
{
    public void ClickToJuho()
    {
        SceneManager.LoadScene("Juho");
    }

    public void ClickToJinhwan()
    {
        SceneManager.LoadScene("Jinhwan");
    }

    public void ClickToSumin()
    {
        SceneManager.LoadScene("Sumin");
    }


}
