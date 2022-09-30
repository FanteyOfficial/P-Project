using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpdateLevel : MonoBehaviour
{
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex != CurrentLevel.scene)
        CurrentLevel.scene = SceneManager.GetActiveScene().buildIndex;
    }

    void Update()
    {
        
    }
}
