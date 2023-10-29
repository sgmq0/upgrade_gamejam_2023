using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPuzzle : MonoBehaviour
{
    public GameObject[] digits;

    [SerializeField] private GameObject panel1;
    [SerializeField] private GameObject panel2;
    [SerializeField] private GameObject panel3;
    [SerializeField] private GameObject safe;
    [SerializeField] private GameObject reward;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (checkWin()) {
            panel1.SetActive(false);
            panel2.SetActive(false);
            panel3.SetActive(false);
            safe.SetActive(false);
            reward.SetActive(true);
        }
    }

    private bool checkWin() {
        if (digits[0].GetComponent<DigitChange>().digit == 1 && //n
            digits[1].GetComponent<DigitChange>().digit == 9 && //e
            digits[2].GetComponent<DigitChange>().digit == 7 && //w
            digits[3].GetComponent<DigitChange>().digit == 1) { //s
            return true;
        } else {
            return false;
        }
    }
}
