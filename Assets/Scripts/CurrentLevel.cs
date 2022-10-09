using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentLevel : MonoBehaviour
{
    public static int scene;
    public static bool keyCardTaken = false;
    public static bool lockOpened = false;

    public static void resetKeySystem()
    {
        keyCardTaken = false;
        lockOpened = false;
    }
}
