using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialPanels : MonoBehaviour
{
    public GameObject ArrowPanel, InteractPanel, Visibility, End;
    // Enables Low Visibility
    public GameObject screen, player;
    // 0 = Arrow Panel, 1 = Interact Panel, 2 = Visibility Panel, 3 = End Panel
    private int mode = 0; 

    // For Waiting
    private float time = 0f;
    private bool waiting = false;
    private float waitLimit = 0f;

    // Start is called before the first frame update
    void Start()
    {
        ArrowPanel.SetActive(true);
        InteractPanel.SetActive(false);
        Visibility.SetActive(false);
        End.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        if (waiting) {
            time += Time.deltaTime;
            if (time >= waitLimit) {
                waiting = false;
                time = 0f;
            }
        } else {
            ListenInputs();
        }
    }

    void ListenInputs() {
        switch (mode) {
            case 0:
                ListenForArrows();
                break;
            case 1:
                ListenForInteract();
                break;
            case 2:
                waiting = true;
                waitLimit = 3f;
                mode = 3;
                break;
            case 3:
                enableEnd();
                waiting = true;
                waitLimit = 2f;
                mode = 4;
                break;
            case 4:
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            default:
                break;
        }
    }

    void ListenForArrows () {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || 
            Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D) ||
            Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) ||
            Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow)) {
            // Deactivate Arrow Panel, Activate Interact Panel
            ArrowPanel.SetActive(false);
            InteractPanel.SetActive(true);
            mode = 1;
        }
    }

    void ListenForInteract () {
        if (Input.GetKeyDown(KeyCode.E)) {
            // Deactivate Interact Panel, Activate Visibility Panel
            InteractPanel.SetActive(false);
            Visibility.SetActive(true);
            screen.transform.position = player.transform.position;
            mode = 2;
        }
    }

    void enableEnd () {
        Visibility.SetActive(false);
        End.SetActive(true);
    }
}
