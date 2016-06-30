using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Inventory : MonoBehaviour {
    
    private RectTransform inventoryRect;
    private float inventoryWidth, inventoryHeight;
    private List<GameObject> allSlots;

    public int slots;
    public int rows;
    public float slotPadingLeft, slotPaddingTop;
    public float slotSize;
    public GameObject slotPrefab;

	// Use this for initialization
	void Start () {
        CreateLayout();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    private void CreateLayout()
    {
        allSlots = new List<GameObject>();

        inventoryWidth = (slots / rows) + (slotSize + slotPadingLeft) + slotPadingLeft;
        inventoryHeight = rows * (slotSize + slotPaddingTop) + slotPaddingTop;

        inventoryRect = GetComponent<RectTransform>();

        inventoryRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, inventoryWidth);
        inventoryRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, inventoryHeight);


    }
}
