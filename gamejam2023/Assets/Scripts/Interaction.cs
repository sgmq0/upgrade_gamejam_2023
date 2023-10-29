using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public string id;
    private GameObject inventory;

    [SerializeField] private GameObject bg;
    [SerializeField] private GameObject image;
    [SerializeField] private GameObject passcode;
    [SerializeField] private Sprite spriteChange; 
    [SerializeField] private GameObject key;

    private Transform player;
    private Transform itemPosition;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.Find("inventory");
        player = GameObject.Find("Player").transform;
        itemPosition = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) )
        {
            float distance = Vector3.Distance(player.position, itemPosition.position);
            if (distance <= 14) {
                if (id == "note") {
                    image.SetActive(true);
                    bg.SetActive(true);
                } else if (id == "body" && invHasItem("knife")) {
                    key.SetActive(true);
                    this.GetComponent<SpriteRenderer>().sprite = spriteChange;
                    id = "body2";
                } else if (id == "door" && invHasItem("key")) {
                    this.GetComponent<SpriteRenderer>().sprite = spriteChange;
                    id = "door2";
                } else if (id == "safe") {
                    image.SetActive(true);
                    bg.SetActive(true);
                    passcode.SetActive(true);
                }
            }
        }
    }

    private bool invHasItem(string name) {
        List<GameObject> items = inventory.GetComponent<Inventory>().itemSpaces;
        for (int i = 0; i < 7; i++) {
            if (items[i].GetComponent<ItemSpace>().itemName == name) {
                return true;
            }
        }
        return false;
    }
}
