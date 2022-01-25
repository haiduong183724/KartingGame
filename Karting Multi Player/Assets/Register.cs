using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;
using System;
using UnityEngine.SceneManagement;

public class Register : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField UserNameField;
    public InputField EmailField;
    public InputField PasswordField;
    public InputField RepassField;
    [SerializeField]
    private string UserName;
    [SerializeField]
    private string Email;
    [SerializeField]
    private string Password;
    [SerializeField]
    private string Repass;
    
    public void OnUserNameChange(string text)
    {
        UserName = text;
    }
    public void OnEmailChange(string text)
    {
        Email = text;
    }
    public void OnPasswordChange(string text)
    {
        Password = text;
    }
    public void OnRepassChange(string text)
    {
        Repass = text;
    }

    private bool CheckValidInput() 
    {
        bool isValid = false;
        if (Password.Equals(Repass) && Password.Length > 5 && Password.Length < 20 && UserName.Length >5) 
        {
            isValid = true;
        }
        return isValid;
    }

    public void OnRegisterClick()
    {
        var request = new RegisterPlayFabUserRequest 
        { 
            Email = Email, 
            TitleId = PlayFabSettings.TitleId,
            Username = UserName,
            Password = Password,
            DisplayName = UserName,
            RequireBothUsernameAndEmail = true,
        };
        PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSucess, OnRegisterFail);
    }

    private void OnRegisterSucess(RegisterPlayFabUserResult obj)
    {
        Debug.Log("Register success");
        SceneManager.LoadScene("Login");
    }
    private void OnRegisterFail(PlayFabError error)
    {
        Debug.Log(error.ErrorMessage);
    }
}
