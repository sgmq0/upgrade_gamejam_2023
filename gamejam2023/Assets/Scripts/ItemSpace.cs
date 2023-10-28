using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ItemSpace : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public string itemName;
    public int id;

    private Inventory inv;

    // Start is called before the first frame update
    void Start()
    {
        GameObject inventoryObject = GameObject.Find("inventory");
        inv = inventoryObject.GetComponent<Inventory>();
        itemName = "null";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData) {
        if (itemName != "null") {
            GameObject label = GameObject.Find("itemLabel");
            label.GetComponent<TextMeshProUGUI>().SetText(itemName);
        }
    }

    public void OnPointerExit(PointerEventData eventData) {
        GameObject label = GameObject.Find("itemLabel");
        label.GetComponent<TextMeshProUGUI>().SetText(" ");
    }

    public void OnPointerDown(PointerEventData eventData) {
        if (itemName != "null") {
            Debug.Log("Used item: " + itemName);
        }
    }
}
