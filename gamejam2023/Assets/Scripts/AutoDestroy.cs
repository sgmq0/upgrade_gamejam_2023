using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoDestroy : MonoBehaviour
{
    public GameObject scareScreen;
    public AudioSource deathSound;
    public ScreenManager screenManager;

    void Start()
    {
    }

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy") {
            scareScreen.SetActive(true);
            deathSound.Play();   
            screenManager.waiting = true;   

            Debug.Log("You Died!");
            Destroy(gameObject);     
        }
    }
}
