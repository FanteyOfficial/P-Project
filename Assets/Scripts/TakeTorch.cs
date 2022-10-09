using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeTorch : MonoBehaviour
{
    [SerializeField] GameObject getButtonUI;
    [SerializeField] GameObject torch;

    bool isTrigger = false;

    void Update()
    {
        if (isTrigger && Input.GetKeyDown(KeyCode.E))
        {
            torch.SetActive(true);
            QuestManagement.tutorialQuest[1] = true;
            getButtonUI.SetActive(false);
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isTrigger = true;
            getButtonUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isTrigger = false;
            getButtonUI.SetActive(false);
        }
    }
}
