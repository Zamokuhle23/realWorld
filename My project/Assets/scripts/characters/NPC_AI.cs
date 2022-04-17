using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC_AI : MonoBehaviour
{
    public GameObject desPoint;
    NavMeshAgent theAgent;
    public static bool fleeMode = false;
    public GameObject fleeDest;
    public AudioSource helpFX;
    public bool isFleeing = false;

    void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
    }

   
    void Update()
    {
        if (!fleeMode)
        {
            theAgent.SetDestination(desPoint.transform.position);
        }
        else
        {
            theAgent.SetDestination(fleeDest.transform.position);

            if (!isFleeing)
            {
                isFleeing = true;
                StartCoroutine(FleeingNPC());
            }
        }
        
    }

    IEnumerator FleeingNPC()
    {
        helpFX.Play();
        yield return new WaitForSeconds(8);
        fleeMode = false;
        isFleeing = false;
        this.gameObject.GetComponent<Animator>().Play("Walking");
        this.gameObject.GetComponent<NavMeshAgent>().speed = 2.5f;
    }
}
