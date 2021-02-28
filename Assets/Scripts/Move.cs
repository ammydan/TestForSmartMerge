using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour
{

    public Transform[] waypoints;
    public NavMeshAgent NMA;

    private int waypoints_index;
    // Start is called before the first frame update
    void Start()
    {
        waypoints_index = 0;
    }
     private void CruisePosition(){
         
      //Debug.DrawLine(transform.position, nextpos, Color.red);
        print(NMA.remainingDistance+" "+"cruisePostion!"+NMA.stoppingDistance);
        if (NMA.remainingDistance <= NMA.stoppingDistance)
        {
           //Debug.Log(NMA.remainingDistance + " : " + NMA.stoppingDistance);
           print("change !!!"+waypoints.Length+" "+waypoints_index+" "+waypoints[waypoints_index].position+" "+transform.position);
            waypoints_index = (waypoints_index + 1) % waypoints.Length;
            NMA.SetDestination(waypoints[waypoints_index].position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        CruisePosition();
        
    }
}
