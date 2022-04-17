using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_RandomDestination : MonoBehaviour
{
    public int trigNum;

  void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NPC")
        {
            trigNum = Random.Range(1, 5);
            if (trigNum == 3)
            {
                this.gameObject.transform.position = new Vector3(4, 1.75f, -310); 
            }
            if (trigNum == 2)
            {
                this.gameObject.transform.position = new Vector3(83, 1.75f, -310); 
            }

            if (trigNum == 1)
            {
                this.gameObject.transform.position = new Vector3(83, 1.75f, -250); 
            }
            if (trigNum == 0)
            {
                this.gameObject.transform.position = new Vector3(4, 1.75f, -250);
            }
        }
    }
}
