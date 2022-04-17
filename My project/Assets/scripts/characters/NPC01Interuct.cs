using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC01Interuct : MonoBehaviour
{
    public AudioSource[] voiceLine;
    public int lineNumber;

void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            StartCoroutine(NPCVoiceover());
        }
    }

    IEnumerator  NPCVoiceover()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        lineNumber = Random.Range(0, 5);
        voiceLine[lineNumber].Play();
        yield return new WaitForSeconds(10);
        this.gameObject.GetComponent<BoxCollider>().enabled = true;
    }

}
