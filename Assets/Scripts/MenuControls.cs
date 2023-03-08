using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public void NewGamePressed()
    {
        SceneManager.LoadScene("A_MainMap");
    }

    public void LoadGamePressed()
    {
        
    }


    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }
}
