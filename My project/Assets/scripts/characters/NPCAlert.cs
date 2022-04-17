using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCAlert : MonoBehaviour
{
    

    void OnTriggerEnter(Collider npc)
    {
        if(npc.tag == "NPC" && !NPCDeath.npcDead)
        {
            npc.GetComponent<Animator>().Play("Running");
            npc.GetComponent<NavMeshAgent>().speed = 5;
            NPC_AI.fleeMode = true;
        }
    }
}
