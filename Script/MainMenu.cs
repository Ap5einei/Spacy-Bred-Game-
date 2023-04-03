using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
   public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Restart()
    {
        Debug.LogError("Restart");
        SceneManager.LoadScene(1);
    }

    public void QuitGame ()
    {
        Debug.LogError("Quit");
        Application.Quit();
    }




   
}
