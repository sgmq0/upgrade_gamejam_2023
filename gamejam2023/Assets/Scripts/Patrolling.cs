using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrolling : MonoBehaviour
{
    // For Patrolling
    [SerializeField] private Transform[] patrolPoints;
    private int currentPoint;
    [SerializeField] private float speed;

    // For Tracking and Chasing
    private bool bloodlust = false;
    [SerializeField] private float chaseSpeed;    
    [SerializeField] private Transform target;
    [SerializeField] private float chaseDistance;


    // Start is called before the first frame update
    void Start() {
        currentPoint = 0;
        bloodlust = false;
        // transform.position = patrolPoints[currentPoint].transform.position;
    }

    void Update() {
        Track();
        if (bloodlust) Chase();
        else {
            Move();
            if (Vector2.Distance(transform.position, patrolPoints[currentPoint].transform.position) == 0) {
                // Debug.Log("New Point");
                currentPoint = (currentPoint + 1) % patrolPoints.Length;
            }
        }
    }
 
    void Move() {
        if (patrolPoints.Length != 0) {
            Vector2 direction = Vector2.MoveTowards(transform.position, 
                            patrolPoints[currentPoint].transform.position, 
                            speed * Time.deltaTime);
            transform.position = direction;
        }
        // Debug.Log("Patrolling: " + transform.position + "To: " + patrolPoints[currentPoint].transform.position);
        // Debug.Log("Current Point: " + currentPoint);
    }

    void Track() {
        // Debug.Log("Tracking");
        if (Vector2.Distance(transform.position, target.position) < chaseDistance) {
            // Debug.Log("I smell blood");
            bloodlust = true;
        } else if (bloodlust) {
            // Debug.Log("Must've been the wind");
            CalculateNewWaypoint();
            bloodlust = false;
        }
    }

    void Chase() {
        // Debug.Log("Chasing");
        transform.position = Vector2.MoveTowards(transform.position, target.position, chaseSpeed * Time.deltaTime);
    }

    void CalculateNewWaypoint() {
        float closestWaypoint = 100f;
        for (int i = 0; i < patrolPoints.Length; i++) {
            float distance = Vector2.Distance(transform.position, patrolPoints[i].transform.position);
            if (distance < closestWaypoint) {
                currentPoint = i;
                closestWaypoint = distance;
            }
        }
    }
}
