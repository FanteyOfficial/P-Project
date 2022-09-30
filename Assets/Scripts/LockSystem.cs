using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockSystem : MonoBehaviour
{
    [SerializeField] GameObject lockUI_Taken;
    [SerializeField] GameObject lockUI_NotTaken;
    [SerializeField] GameObject keyObject;

    [SerializeField] GameObject wallSpawn;
    [SerializeField] GameObject lightSpawn;

    [SerializeField] GameObject monitorOn;
    [SerializeField] GameObject monitorOff;

    bool isTrigger = false;

    void Start()
    {

    }

    void Update()
    {
        lockManagement();
    }

    void lockManagement()
    {
        if (isTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                CurrentLevel.lockOpened = true;
            }
        }
        if (CurrentLevel.lockOpened)
        {
            GetComponent<Collider>().enabled = false;
            lockUI_Taken.SetActive(false);
            keyObject.SetActive(true);
            
            wallSpawn.SetActive(true);
            lightSpawn.SetActive(true);

            monitorOff.SetActive(false);
            monitorOn.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (CurrentLevel.keyCardTaken)
            {
                lockUI_Taken.SetActive(true);
                isTrigger = true;
            }
            else
            {
                lockUI_NotTaken.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isTrigger = false;
            lockUI_Taken.SetActive(false);
            lockUI_NotTaken.SetActive(false);
        }
    }
}
