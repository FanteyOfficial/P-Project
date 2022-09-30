using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void restart()
    {
        CurrentLevel.resetKeySystem();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        SceneManager.LoadScene(CurrentLevel.scene);
    }

    public void backMenu()
    {
        CurrentLevel.resetKeySystem();
        SceneManager.LoadScene("StartMenu");
    }
}
