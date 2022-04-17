using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AA_Opening : MonoBehaviour
{
    public GameObject fadeIn;
    public GameObject theText;
    public GameObject initialCam;
    public GameObject fadeOut;
    public GameObject thePlayer;
  

    void Start()
    {
        StartCoroutine(OpenBegin());
    }
    IEnumerator OpenBegin()
    {
        yield return new WaitForSeconds(1);
        theText.SetActive(true);
        yield return new WaitForSeconds(7);
        fadeIn.GetComponent<Animator>().enabled = true;
        initialCam.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(3);
        fadeOut.SetActive(true);
        fadeIn.SetActive(false);
        yield return new WaitForSeconds(2);
 
        thePlayer.SetActive(true);
        initialCam.SetActive(false);
        fadeOut.SetActive(false);
        yield return new WaitForSeconds(1);
        //fadeIn.SetActive(true);
        //fadeIn.GetComponent<Animator>().Play("fadeInAnim");
    }

}
