using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public string id;

    [SerializeField] private GameObject noteBg;
    [SerializeField] private GameObject noteImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if (id == "note") {
            noteImage.SetActive(true);
            noteBg.SetActive(true);
        }
    }
}
