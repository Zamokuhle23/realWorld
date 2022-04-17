using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class A03_voiceOver : MonoBehaviour
{
    public GameObject subText;
    public AudioSource voice1;
    public AudioSource voice2;
    //public AudioSource voice3;
    public AudioSource loudBang;
    public GameObject blackScreen;
    public GameObject deadBody;
    public GameObject sack;
    public GameObject cop;
    public GameObject theChar;
    public GameObject theGun;
    public GameObject fourCam;
    public GameObject fadeOut;

    void Start()
    {
        StartCoroutine(IntroSubs());
    }

    IEnumerator IntroSubs()
    {
        yield return new WaitForSeconds(8);
        voice1.Play();
        subText.GetComponent<Text>().text = "I told you, you can Run but you can not hide, Mr Phillip!";
        subText.SetActive(true);
        yield return new WaitForSeconds(7);
        subText.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        subText.GetComponent<Text>().text = "But...But I wasn't Running.";
        voice2.Play();
        yield return new WaitForSeconds(3);
        subText.GetComponent<Text>().text = "";
        loudBang.Play();
        blackScreen.SetActive(true);
        deadBody.SetActive(true);
        theChar.SetActive(false);
        cop.SetActive(false);
        sack.SetActive(false);
        //yield return new WaitForSeconds(2);
        //subText.GetComponent<Text>().text = "M";
        //voice3.Play();
        yield return new WaitForSeconds(2);
        blackScreen.SetActive(true);
        yield return new WaitForSeconds(2);
        blackScreen.SetActive(false);
        fourCam.SetActive(true);
        yield return new WaitForSeconds(4);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(1);




    }

 
}
