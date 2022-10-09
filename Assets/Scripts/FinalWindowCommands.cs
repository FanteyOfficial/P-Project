using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalWindowCommands : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void backMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void quit()
    {
        Application.Quit();
    }
}
