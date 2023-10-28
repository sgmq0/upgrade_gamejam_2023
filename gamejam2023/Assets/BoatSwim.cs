using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatSwim : MonoBehaviour
{
    public float speed;
    private float speedX;
    public float limitXL;
    public float limitXR;
    // Start is called before the first frame update
    void Start()
    {
        speedX = speed;
        // transform.position = new Vector3(-4, -2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Move Boat
        transform.position += new Vector3(speedX, 0, 0);
        if (transform.position.x > limitXR) {
            speedX = -speed;
            Debug.Log("SpeedX Right: " + speedX);
        } else if (transform.position.x < limitXL) {
            speedX = speed;
            Debug.Log("SpeedX Left: " + speedX);
        }
    }
}
