using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    LevelManager LM; 

    void Start()
    {
        LM = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){

        if(other.gameObject.CompareTag("Player")){

            Debug.Log("Player be resonating with their good memories or something");
            LM.LevelBeat();
        }
    }
}
