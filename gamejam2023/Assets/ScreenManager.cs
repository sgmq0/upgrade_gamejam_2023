using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    public GameObject deathScreen;
    public GameObject scareScreen;
    public AudioSource deathSound;
    float scareTimer = 0.5f;
    public bool waiting;
    // Start is called before the first frame update
    void Start()
    {
        deathScreen.SetActive(false);
        scareScreen.SetActive(false);
        waiting = false;
    }

    // Update is called once per frame
    void Update() {
        // Debug.Log("waiting: " + waiting);
        if (waiting) {
            // Debug.Log("waiting for death " + scareTimer);
            scareTimer -= Time.deltaTime;
            if (scareTimer <= 0) {
                scareScreen.SetActive(false);
                deathScreen.SetActive(true);
            }
        }
    }
}
