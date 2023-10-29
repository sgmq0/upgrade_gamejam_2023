using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<GameObject> itemList;
    public List<GameObject> itemSpaces;

    public int objsInList;

    // Start is called before the first frame update
    void Start()
    {
        itemList = new();
        for (int i = 0; i < 7; i++) {
            GameObject child = this.gameObject.transform.GetChild(i).gameObject;
            itemSpaces.Add(child);
        }
        objsInList = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addItem(GameObject i) {
        itemList.Add(i);
        GameObject obj = itemSpaces[objsInList];
        obj.GetComponent<Image>().sprite = i.GetComponent<Item>().itemSprite;

        Color newColor = obj.GetComponent<Image>().color;
        newColor.a = 1;
        obj.GetComponent<Image>().color = newColor;

        obj.GetComponent<ItemSpace>().itemName = i.GetComponent<Item>().itemName;
        Destroy(i);
        objsInList++;
        
    }

}
