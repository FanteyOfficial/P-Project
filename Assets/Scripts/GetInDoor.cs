using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInDoor : MonoBehaviour
{
    [SerializeField] int doorNumber;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            switch(doorNumber)
            {
                case 1:
                    QuestManagement.quest3[1] = true;
                    break;
                case 2:
                    QuestManagement.quest4[1] = true;
                    break;
                case 3:
                    QuestManagement.quest5[1] = true;
                    break;
            }
            gameObject.SetActive(false);
        }
    }
}
