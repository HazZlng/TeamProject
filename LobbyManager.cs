using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyManager: MonoBehaviour
{
    public void ClickToSelect()
    {
        SceneManager.LoadScene("Select");
    }

    public void ClickToExit()
    {
        Application.Quit();
    }
    public void ClickToLobby()
    {
        SceneManager.LoadScene("Lobby");
    }
}
