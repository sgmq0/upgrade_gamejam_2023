using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Transform player;
    public GameObject playerObject;

    // Start is called before the first frame update
    void Start()
    {
        player = playerObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null) {
            transform.position = new Vector3(player.position.x, player.position.y, -10);
        } else {
            transform.position = new Vector3(1,1,-10);
        }
        
    }
}
