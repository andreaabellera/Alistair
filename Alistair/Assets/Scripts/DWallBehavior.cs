using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DWallBehavior : MonoBehaviour
{
    public float speed;
    public Transform target;
    LevelManager LM; 
    void Start()
    {
        LM = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        
    }

    // Update is called once per frame
    void Update()
    {       
        float step = speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
        
    }

    void OnTriggerEnter(Collider other){

        if(other.gameObject.CompareTag("Player")){

            Debug.Log("Player be dead");
            LM.LevelLost();
        }
    }
}
