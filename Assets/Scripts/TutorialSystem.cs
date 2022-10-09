using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialSystem : MonoBehaviour
{
    [SerializeField] GameObject playerTorch;
    [SerializeField] GameObject tutorial;

    void Start()
    {
        if (!QuestManagement.tutorialDone)
        {
            playerTorch.SetActive(false);
            tutorial.SetActive(true);
        }
    }

    void Update()
    {
        if (QuestManagement.tutorialDone)
        {
            tutorial.SetActive(false);
        }
    }
}
