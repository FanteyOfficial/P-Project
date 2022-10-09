using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TutorialActivation : MonoBehaviour
{
    void Start()
    {
        if (QuestManagement.tutorialDone && !QuestManagement.tutorialQuest.All(x => x)) // se il tutorial é true, ma il le subQuest non sono completate, attiva il tutorial
        {
            QuestManagement.tutorialDone = false;
        }
    }
}
