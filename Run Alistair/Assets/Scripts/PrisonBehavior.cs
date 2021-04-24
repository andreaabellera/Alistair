using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrisonBehavior : MonoBehaviour
{
    public GameObject bunny;
    public GameObject[] DeathWall;

  void OnTriggerExit(Collider other){

        if(other.gameObject.CompareTag("Player")){

            Debug.Log("Player Has Left Prison");
            bunny.SetActive(true);

            foreach(GameObject DW in DeathWall){
            DW.SetActive(true);
            }
        }
    }
}
