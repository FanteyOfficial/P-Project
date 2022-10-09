using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void startGame()
    {
        SceneManager.LoadScene("MappaTest");
    }

    public void quit()
    {
        Application.Quit();
    }
}
