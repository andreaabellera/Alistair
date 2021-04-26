using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyAI : MonoBehaviour
{
    public enum FSMStates
    {
        Patrol,
    }

    public FSMStates currentState;

    public float speed = 5f;

    public GameObject[] wanderPts;
    Vector3 nextDestination;

    int currentDestination = 0;

    public GameObject player;
    UnityEngine.AI.NavMeshAgent agent;

    void Start()
    {
      player = GameObject.FindGameObjectWithTag("Player");
      Initialize();
      agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {


        switch(currentState){

            case FSMStates.Patrol:
                UpdatePatrolState();
                break;
        }
    }

    void UpdatePatrolState(){

        print("Patrolling");
         agent.stoppingDistance = 0;
         agent.speed = speed;

        if(Vector3.Distance(transform.position, nextDestination) < 1){

            FindNextPoint();
        }

        FaceTarget(nextDestination);

        agent.SetDestination(nextDestination);

        
    }


    private void Initialize(){

        currentState = FSMStates.Patrol;
        FindNextPoint();
    
        
    }

    void FaceTarget(Vector3 target){

        Vector3 directionTarget = (target - transform.position).normalized;
        directionTarget.y = 0;
        if (directionTarget != Vector3.zero) {

        Quaternion lookRotation = Quaternion.LookRotation(directionTarget);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, 10 * Time.deltaTime);
        }
    }

    void FindNextPoint(){

        nextDestination = wanderPts[currentDestination].transform.position;

        if(currentDestination + 1 < wanderPts.Length){

            currentDestination ++;
        }

    }

}
