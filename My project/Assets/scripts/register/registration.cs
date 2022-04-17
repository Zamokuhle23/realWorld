using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class registration : MonoBehaviour
{
    public InputField namefield;
    public InputField password;
    public InputField passwordConfirm;
    public Button submitButton;
    public void CallRegister()
    {
        StartCoroutine(Register());
    }

    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("username", namefield.text);
        form.AddField("password", password.text);

        
        WWW www = new WWW("http://127.0.0.1/registration.php", form);
        yield return www;
        Debug.Log(password.text);
        string result = www.text;

        if (!String.Equals(result, "0"))
        {
            Debug.Log("User Created Successfully");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        else
        {
            Debug.Log(result);
        }


        
    }
    public void VerifyInputs()
    {
        submitButton.interactable = (password.text == passwordConfirm.text);
    }

}
