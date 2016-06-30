using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {

    public int columns, slotAmt;
    public GameObject invSlot;
    public GameObject row;
    

	// Use this for initialization
	void Start () {
        MakeRows();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void MakeRows()
    {
        int rows = slotAmt / columns;
        int slotsPlaced = 0;
        for (int i = 0; i <= rows; i++)
        {
            GameObject newRow = (GameObject)Instantiate(row) as GameObject;
            newRow.transform.SetParent(transform);
            for(int y = 0; y <= columns; y++)
            {
                GameObject newSlot = (GameObject)Instantiate(invSlot) as GameObject;
                newSlot.transform.SetParent(newRow.transform);
                slotsPlaced++;
                if (slotsPlaced == slotAmt)
                    return;
            }
        }
    }
}
