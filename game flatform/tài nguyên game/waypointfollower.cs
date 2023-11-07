using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waypointfollower : MonoBehaviour
{
    
 [SerializeField] private GameObject[]waypoints;
    private int currentwaypoint=0;
    [SerializeField] private float speed =2f ;
    void Update()
    {
        if(Vector2.Distance(waypoints[currentwaypoint].transform.position,transform.position)<.1f){
            currentwaypoint ++;
            if(currentwaypoint >=waypoints.Length){
             currentwaypoint =0;
            }

        }            transform.position = Vector2.MoveTowards(transform.position,waypoints[currentwaypoint]. transform.position,Time.deltaTime*speed);
    }
}
