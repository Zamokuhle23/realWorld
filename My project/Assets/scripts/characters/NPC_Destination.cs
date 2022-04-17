using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Destination : MonoBehaviour
{
    public int trigNum;

  void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NPC")
        {

            if (trigNum == 3)
            {
                this.gameObject.transform.position = new Vector3(4, 1.75f, -310); 
                trigNum = 0;
            }
            if (trigNum == 2)
            {
                this.gameObject.transform.position = new Vector3(83, 1.75f, -310); 
                trigNum = 3;
            }

            if (trigNum == 1)
            {
                this.gameObject.transform.position = new Vector3(83, 1.75f, -250); 
                trigNum = 2;
            }
            if (trigNum == 0)
            {
                this.gameObject.transform.position = new Vector3(4, 1.75f, -250);
                trigNum = 1;
            }
        }
    }
}
