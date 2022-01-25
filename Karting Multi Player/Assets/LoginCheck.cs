using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.SceneManagement;
public class LoginCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField EmailField;
    public InputField PaswordField;

    private string Email;
    private string Password;
    public void OnUserNameChange(string text)
    {
        Email = text;
    }
    public void OnPasswordChange(string text)
    {
        Password = text;
    }


    public void OnLoginClick(){
        var Request = new LoginWithEmailAddressRequest
        {
            Email = Email,
            Password = Password,
            TitleId = PlayFabSettings.TitleId
        };
        PlayFabClientAPI.LoginWithEmailAddress(Request, result =>
        {
            SceneManager.LoadScene("MainScene");
            Debug.Log("Login Successfull");

        }, error =>
        {
            Debug.Log(error.ErrorMessage);
        });

    }
}
