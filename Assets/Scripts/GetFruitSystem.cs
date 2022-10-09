using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFruitSystem : MonoBehaviour
{
    [SerializeField] int fruitNum;

    [SerializeField] GameObject door;

    [SerializeField] GameObject pacmanNewPosition;
    [SerializeField] GameObject newSectorToActivate;
    [SerializeField] GameObject oldSectorToDeactivate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            oldSectorToDeactivate.SetActive(false);
            pacmanNewPosition.SetActive(true);
            newSectorToActivate.SetActive(true);

            gameObject.SetActive(false);
            door.GetComponent<Collider>().isTrigger = true;
            door.GetComponent<MeshRenderer>().enabled = false;
            switch (fruitNum) {
                case 1:
                    QuestManagement.quest3[0] = true;
                    break;
                case 2:
                    QuestManagement.quest4[0] = true;
                    break;
                case 3:
                    QuestManagement.quest5[0] = true;
                    break;
            }
        }
    }
}
