using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialPanels : MonoBehaviour
{
    public GameObject ArrowPanel, InteractPanel, Visibility, End;
    // 0 = Arrow Panel, 1 = Interact Panel, 2 = Visibility Panel, 3 = End Panel
    private int mode = 0; 

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
        ListenInputs();
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
                if (Input.GetKeyDown(KeyCode.Space)) {
                    // Deactivate Visibility Panel, Activate End Panel
                    Visibility.SetActive(false);
                    End.SetActive(true);
                    mode = 3;
                }
                break;
            case 3:
                if (Input.GetKeyDown(KeyCode.Space)) {
                    // Deactivate End Panel, Activate Arrow Panel
                    End.SetActive(false);
                    ArrowPanel.SetActive(true);
                    mode = 0;
                }
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
        }
    }

    void ListenForInteract () {
        if (Input.GetKeyDown(KeyCode.E)) {
            // Deactivate Interact Panel, Activate Visibility Panel
            InteractPanel.SetActive(false);
            Visibility.SetActive(true);
        }
    }

    void wait (float seconds) {
        float start = Time.time;
        while (Time.time < start + seconds) {
            // Do nothing
        }
    }

    void enableEnd () {
        Visibility.SetActive(false);
        End.SetActive(true);
    }
}
