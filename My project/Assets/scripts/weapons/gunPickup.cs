using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunPickup : MonoBehaviour
{
    public GameObject pistol;
    public AudioSource pickup;
    public GameObject pistolFire;

    void OnTriggerEnter(Collider other)
    {
        pickup.Play();
        pistol.SetActive(true);
        pistolFire.SetActive(true);
        this.gameObject.SetActive(false);

    }


}
