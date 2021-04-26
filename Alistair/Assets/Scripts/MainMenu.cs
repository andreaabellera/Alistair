using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start(){

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
      public void StartGame(){

      SceneManager.LoadScene("Elena scene");
  }

  public void ExitGame(){

      Application.Quit();

  }

    public void LoadMainMenu(){

        SceneManager.LoadScene(0);

    }

    public void LoadNextLevel() {

        string levelname = PlayerPrefs.GetString("currentLevel");

         SceneManager.LoadScene(levelname);
    }
}
