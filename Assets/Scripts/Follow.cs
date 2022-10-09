using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Follow : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 5f;
    [SerializeField] Animator anim;

    [SerializeField] AudioClip footstepsAudio;
    [SerializeField] AudioClip verse;

    AudioSource audioSource;

    NavMeshAgent navMeshAgent;
    //float distanceToTarget = Mathf.Infinity;
    float distanceToTarget;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position); // distance between us and player

        if (distanceToTarget <= chaseRange)
        {
            anim.enabled = true;
            navMeshAgent.SetDestination(target.position);
            audioSource.PlayOneShot(footstepsAudio);
            audioSource.PlayOneShot(verse);
        }
        else
        {
            anim.enabled = false;
            audioSource.Stop();
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }
}
