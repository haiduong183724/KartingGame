using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackOption : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene("FirstScene");
    }
}
