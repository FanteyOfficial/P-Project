using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalButton : MonoBehaviour
{
    [SerializeField] GameObject monitorOff;
    [SerializeField] GameObject buttonOn;
    [SerializeField] GameObject buttonOff;
    [SerializeField] GameObject allOn;
    [SerializeField] GameObject PressButtonScreen;

    [SerializeField] GameObject spawnPortal;

    bool isTrigger = false;

    void Update()
    {
        if (isTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                turnOffAll();
                gameObject.GetComponent<BoxCollider>().enabled = false;
                PressButtonScreen.SetActive(false);
                spawnPortal.SetActive(true);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            isTrigger = true;
            PressButtonScreen.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {            
            isTrigger = false;
            PressButtonScreen.SetActive(false);
        }
    }

    void turnOffAll()
    {
        monitorOff.SetActive(true);
        buttonOff.SetActive(true);
        allOn.SetActive(false);
        buttonOn.SetActive(false);
    }
}
