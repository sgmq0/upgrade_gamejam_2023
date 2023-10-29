using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public string id;

    [SerializeField] private GameObject noteBg;
    [SerializeField] private GameObject noteImage;

    private Transform player;
    private Transform itemPosition;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
        itemPosition = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            float distance = Vector3.Distance(player.position, itemPosition.position);
            if (distance <= 14) {
                noteImage.SetActive(true);
                noteBg.SetActive(true);
            }
        }
    }
}
