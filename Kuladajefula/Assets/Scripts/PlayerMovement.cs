using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    public NavMeshAgent agent;
    public float distance = 1000f;
    private Camera cam;

    private void Start()
    {
        cam = Camera.main;
    }


    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out var hit, Mathf.Infinity) == true)
            {
                if(NavMesh.SamplePosition(hit.point, out NavMeshHit navHit, 0.1f, NavMesh.AllAreas))
                {
                    agent.destination = navHit.position;
                }
               
            }
        }
    }
    

}
