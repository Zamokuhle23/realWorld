using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A02_MoveChar : MonoBehaviour
{
    public AudioSource footstep;
    public GameObject mainChar;
    public int steps = 0;
    void Start()
    {
        StartCoroutine(WalkSequence());
    }

    // Update is called once per frame
    void Update()
    {
        mainChar.transform.Translate(0, 0, 0.04f * Time.timeScale);
    }
    IEnumerator WalkSequence()
    {
        yield return new WaitForSeconds(0.4f);
        while(steps < 12)
        {
           yield return new WaitForSeconds(0.5f);
            footstep.Play();
            steps += 1;
        }
        mainChar.SetActive(false);
    }
    
}
