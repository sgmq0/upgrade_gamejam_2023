using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrolling : MonoBehaviour
{
    public Transform[] patrolPoints;
    private int currentPoint;
    public NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();

        agent.autoBraking = false;

        GotoNextPoint();
    }

    void GotoNextPoint() {
        // if there are no points, return
        if (patrolPoints.Length == 0) {
            return;
        }
        agent.destination = patrolPoints[currentPoint].position;

        currentPoint = (currentPoint + 1) % patrolPoints.Length;
    }

    // Update is called once per frame
    void Update() {
        if (!agent.pathPending && agent.remainingDistance < 0.2f) {
            GotoNextPoint();
        }
    }
}
