using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int itemId;
    public string itemName;
    public Sprite itemSprite;
    private Inventory inv;

    // Start is called before the first frame update
    void Start()
    {
        GameObject inventoryObject = GameObject.Find("inventory");
        inv = inventoryObject.GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown() {
        inv.addItem(this.gameObject);
    }

}
