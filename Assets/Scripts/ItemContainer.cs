using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemContainer {
    private List<Item> consumables = new List<Item>();

    public List<Item> Consumables
    {
        get
        {
            return consumables;
        }

        set
        {
            consumables = value;
        }
    }
}
