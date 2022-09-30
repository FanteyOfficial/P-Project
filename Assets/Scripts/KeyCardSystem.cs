using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCardSystem : MonoBehaviour
{
    [SerializeField] GameObject key;
    [SerializeField] GameObject takeKeyUI;
    [SerializeField] GameObject keyTakenUI;

    bool isTriggerGetKey = false;

    void Start()
    {
        CurrentLevel.keyCardTaken = false;
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
            }
        }
        if (CurrentLevel.keyCardTaken)
        {
            GetComponent<Collider>().enabled = false;
            key.SetActive(false);
            takeKeyUI.SetActive(false);
            keyTakenUI.SetActive(true);
        }
    }

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
