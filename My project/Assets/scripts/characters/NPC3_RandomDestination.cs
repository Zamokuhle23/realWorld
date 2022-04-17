using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC3_RandomDestination : MonoBehaviour
{
    public int trigNum;

  void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NPC")
        {
            trigNum = Random.Range(1, 5);
            if (trigNum == 3)
            {
                this.gameObject.transform.position = new Vector3(78, 1.75f, -177); 
                //trigNum = 0;
            }
            if (trigNum == 2)
            {
                this.gameObject.transform.position = new Vector3(103, 1.75f, -27); 
                //trigNum = 3;
            }

            if (trigNum == 1)
            {
                this.gameObject.transform.position = new Vector3(-37, 1.75f, -27); 
                //trigNum = 2;
            }
            if (trigNum == 0)
            {
                this.gameObject.transform.position = new Vector3(-37, 1.75f, -215);
                //trigNum = 1;
            }
        }
    }
}
