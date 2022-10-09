using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class QuestSystem : MonoBehaviour
{
    [SerializeField] GameObject tutorial;
    [SerializeField] TMP_Text subTutorial1;
    [SerializeField] TMP_Text subTutorial2;
    [SerializeField] TMP_Text subTutorial3;

    [SerializeField] GameObject quest1;
    [SerializeField] GameObject quest2;
    
    [SerializeField] GameObject quest3;
    [SerializeField] TMP_Text subQuest3_1;
    [SerializeField] TMP_Text subQuest3_2;

    [SerializeField] GameObject quest4;
    [SerializeField] TMP_Text subQuest4_1;
    [SerializeField] TMP_Text subQuest4_2;

    [SerializeField] GameObject quest5;
    [SerializeField] TMP_Text subQuest5_1;
    [SerializeField] TMP_Text subQuest5_2;

    [SerializeField] GameObject quest6;

    void Update()
    {
        questSwitch();
        subQuestControl();
    }

    void subQuestControl()
    {
        for (int i = 0; i < 3; i++)
        {
            if (QuestManagement.tutorialQuest[i] && !QuestManagement.tutorialDone)
            {
                switch (i)
                {
                    case 0:
                        subTutorial1.fontStyle = FontStyles.Strikethrough;
                        break;
                    case 1:
                        subTutorial2.fontStyle = FontStyles.Strikethrough;
                        break;
                    case 2:
                        subTutorial3.fontStyle = FontStyles.Strikethrough;
                        break;
                }
            }
        }

        for (int i = 0; i < 2; i++)
        {
            if (QuestManagement.quest3[i] && !QuestManagement.quest3Done)
            {
                switch (i)
                {
                    case 0:
                        subQuest3_1.fontStyle = FontStyles.Strikethrough;
                        break;
                    case 1:
                        subQuest3_2.fontStyle = FontStyles.Strikethrough;
                        break;
                }
            }
            if (QuestManagement.quest4[i] && !QuestManagement.quest4Done)
            {
                switch (i)
                {
                    case 0:
                        subQuest4_1.fontStyle = FontStyles.Strikethrough;
                        break;
                    case 1:
                        subQuest4_2.fontStyle = FontStyles.Strikethrough;
                        break;
                }
            }
            if (QuestManagement.quest5[i] && !QuestManagement.quest5Done)
            {
                switch (i)
                {
                    case 0:
                        subQuest5_1.fontStyle = FontStyles.Strikethrough;
                        break;
                    case 1:
                        subQuest5_2.fontStyle = FontStyles.Strikethrough;
                        break;
                }
            }
        }
        if (QuestManagement.tutorialQuest.All(x => x)) QuestManagement.tutorialDone = true;
        if (QuestManagement.quest3.All(x => x)) QuestManagement.quest3Done = true; // controllo se l'array di valori booleani ha tutti gli elementi impostati su true
        if (QuestManagement.quest4.All(x => x)) QuestManagement.quest4Done = true;
        if (QuestManagement.quest5.All(x => x)) QuestManagement.quest5Done = true;
    }

    void questSwitch()
    {
        if (!QuestManagement.tutorialDone)
        {
            tutorial.SetActive(true);
        }

        if (QuestManagement.tutorialDone)
        {
            tutorial.SetActive(false);
            quest1.SetActive(true);
        }
        if (QuestManagement.quest1Done)
        {
            quest1.SetActive(false);
            quest2.SetActive(true);
        }
        if (QuestManagement.quest2Done)
        {
            quest2.SetActive(false);
            quest3.SetActive(true);
        }
        if (QuestManagement.quest3Done)
        {
            quest3.SetActive(false);
            quest4.SetActive(true);
        }
        if (QuestManagement.quest4Done)
        {
            quest4.SetActive(false);
            quest5.SetActive(true);
        }
        if (QuestManagement.quest5Done)
        {
            quest5.SetActive(false);
            quest6.SetActive(true);
        }
    }
}
