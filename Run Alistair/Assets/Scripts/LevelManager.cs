using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    public bool isGameOver = false; 
    public string nextLevel;
    //public Text gameOverText;

    //public static Text noteText;
    //public static GameObject currentNote;

    //public Text winText;
    //public Text deadText;
    //public Image textBackground;
    //public AudioClip lostSFX;
    //public AudioClip winSFX;

    // Start is called before the first frame update
    void Start()
    {
        isGameOver = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LevelLost() {

        if(!isGameOver){

         Debug.Log("Level Lost");

        isGameOver = true;

        Invoke("LoadEndScene", 0);
        }
    }

    public void LevelBeat() {

        if(!isGameOver){

         Debug.Log("Level Beat");

        isGameOver = true;

        Invoke("LoadNextLevel", 0);
        }
    
    }

    void LoadNextLevel() {

         SceneManager.LoadScene(nextLevel);
    }

    void LoadCurrentLevel(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    void LoadEndScene(){

        SceneManager.LoadScene("EndScene");
    }
}
