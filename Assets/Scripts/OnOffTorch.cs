using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffTorch : MonoBehaviour
{
    [SerializeField] GameObject light;
    bool isActive = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            isActive = !isActive;
            light.gameObject.SetActive(isActive);
        }
    }
}
