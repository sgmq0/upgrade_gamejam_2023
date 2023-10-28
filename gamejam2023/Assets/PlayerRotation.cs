using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    // private Quaternion q = Euler(0, 0, 90);
    private Vector2 direction;
    
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        direction = new Vector2(0, 0);
    }

    void Update() {
        // Rotate(Input.GetKey(KeyCode.UpArrow), Input.GetKey(KeyCode.RightArrow));
    }

    public void Rotate(bool up, bool right) {
        // transform.rotation = Quaternion.Euler(0, 0, 90);
    }
}
