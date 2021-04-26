using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrisonBehavior : MonoBehaviour
{
    public GameObject bunny;
    public GameObject[] DeathWall;
    private bool left = false;
    AudioSource AS;

    void Start(){

        AS = GetComponent<AudioSource>();
    }

  void OnTriggerExit(Collider other){

        if(other.gameObject.CompareTag("Player") && !left){

            Debug.Log("Player Has Left Prison");
            AS.Play(0);
            bunny.SetActive(true);
            foreach(GameObject DW in DeathWall){
            DW.SetActive(true);
            }
            left = true;
        }
    }
}
