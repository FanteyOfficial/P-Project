using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalWindowCommands : MonoBehaviour
{
    public void backMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void quit()
    {
        Application.Quit();
    }
}
