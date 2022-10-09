using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using UnityEngine;

public class KeyCardSystem : MonoBehaviour
{
    [SerializeField] GameObject key;
    [SerializeField] GameObject takeKeyUI;
    [SerializeField] GameObject keyTakenUI;

    // [SerializeField] AudioClip plin;

    // AudioSource audioSource;

    bool isTriggerGetKey = false;

    void Start()
    {
        CurrentLevel.keyCardTaken = false;
        // audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        keyManagement();
    }

    void keyManagement()
    {
        if (isTriggerGetKey)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                CurrentLevel.keyCardTaken = true;

                // audioSource.PlayOneShot(plin);
                // Invoke("stopAudio", 1f);
            }
        }
        if (CurrentLevel.keyCardTaken)
        {
            QuestManagement.quest1Done = true;
            Debug.Log(QuestManagement.quest1Done);

            GetComponent<Collider>().enabled = false;
            key.SetActive(false);
            takeKeyUI.SetActive(false);
            keyTakenUI.SetActive(true);
        }
    }

    /*void stopAudio()
    {
        audioSource.Stop();
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isTriggerGetKey = true;
            takeKeyUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isTriggerGetKey = false;
            takeKeyUI.SetActive(false);
        }
    }
}
