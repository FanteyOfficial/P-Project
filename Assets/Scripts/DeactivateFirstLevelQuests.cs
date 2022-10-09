using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateFirstLevelQuests : MonoBehaviour
{
    void Start()
    {
        QuestManagement.quest1Done = true;
        QuestManagement.quest2Done = true;
    }
}
