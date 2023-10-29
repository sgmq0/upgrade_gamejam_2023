using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int itemId;
    public string itemName;
    public Sprite itemSprite;
    private Transform player;
    private Transform itemPosition;
    private Inventory inv;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
        GameObject inventoryObject = GameObject.Find("inventory");
        itemPosition = this.gameObject.transform;
        inv = inventoryObject.GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            float distance = Vector3.Distance(player.position, itemPosition.position);
            if (distance <= 14) {
                inv.addItem(this.gameObject);
            }
        }

    }

}
