using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAnim : MonoBehaviour
{
    Animator anim;
    private Vector2 lastPosition;
    private Vector2 currPosition;

    private bool horizontal = false;
    private bool vertical = true;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        lastPosition = currPosition = transform.position;
    }

    // Update is called once per frame
    void Update() {
        // What is my Position?
        currPosition = transform.position;
        // With respect to my last position, what is my orientation?
        Vector2 orientation = new Vector2 (lastPosition.x - currPosition.x, lastPosition.y - currPosition.y);
        // Update lastPosition
        lastPosition = currPosition;

        // Change Animation
        if (Mathf.Abs(orientation.x) > Mathf.Abs(orientation.y) && vertical) {
            anim.SetTrigger("GoHorizontal");
            horizontal = true;
            vertical = false;
        } else if (Mathf.Abs(orientation.x) < Mathf.Abs(orientation.y) && horizontal) {
            anim.SetTrigger("GoVertical");
            vertical = true;
            horizontal = false;
        }

        // Flip Sprite
        
        float newX = 0;
        float newY = 0;
        // If I'm moving left and facing right, flip
        // If I'm moving right and facing left, flip
        if (horizontal) {
            if (orientation.x < 0 && transform.localScale.x > 0) newX = -2;
            else if (orientation.x > 0 && transform.localScale.x < 0) newX = -2;
        }
        
        // If I'm moving down and facing up, flip
        // If I'm moving up and facing down, flip
        if (vertical) {
            if (orientation.y < 0 && transform.localScale.y > 0) newY = -2;
            else if (orientation.y > 0 && transform.localScale.y < 0) newY = -2;
        }
        // It has to be -2 because the scale is 1 by default
        // So 1 + -2 = -1, which is a flip

        // Make a new Vector3 with the new scale
        Vector3 newScale = new Vector3 (newX * transform.localScale.x, newY * transform.localScale.y, 0);
        transform.localScale += newScale;
    }
}
