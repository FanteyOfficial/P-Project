using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField] string tag="Player";

    /*private void OnTriggerEnter(Collision other)
    {
        Debug.Log("collisione");
        if (other.gameObject.tag == tag)
        {
            Debug.Log(tag);
            SceneManager.LoadScene("DeathScene");
        }
    }*/
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == tag)
        {
            SceneManager.LoadScene("DeathScene");
        }
    }
}
