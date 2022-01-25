using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OptionSelect : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnLoginClick()
    {
        SceneManager.LoadScene("Login");
    }
    public void OnRegisterClick()
    {
        SceneManager.LoadScene("Register");
    }    


}
