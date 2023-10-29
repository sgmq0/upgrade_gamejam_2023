using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class DigitChange : MonoBehaviour
{
    public int digit;
    // Start is called before the first frame update
    void Start()
    {
        digit = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void click() {
        digit++;
        if (digit == 10) {
            digit = 0;
        }
        this.GetComponent<TextMeshProUGUI>().SetText(digit.ToString());
    }

    public void setToZero() {
        digit = 0;
        this.GetComponent<TextMeshProUGUI>().SetText(digit.ToString());
    }
}
