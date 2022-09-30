using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject PauseUI;
    [SerializeField] GameObject PlayerUI;
    [SerializeField] static bool inPause = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!inPause)
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
    }

    public void PauseGame()
    {
        PlayerUI.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        // GameUI.SetActive(false);
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        inPause = true;
    }

    public void ResumeGame()
    {
        PlayerUI.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        // GameUI.SetActive(true);
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        inPause = false;
    }

    public void BackMenu()
    {
        ResumeGame();
        CurrentLevel.resetKeySystem();

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        SceneManager.LoadScene("StartMenu");
    }

    public void Restart()
    {
        ResumeGame();
        CurrentLevel.resetKeySystem();

        SceneManager.LoadScene(CurrentLevel.scene);
    }
}
