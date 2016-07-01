using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum ItemType {Consumable, Equipment, Weapon};

public abstract class Item {

    public int id;

    public ItemType type { get; set; }
    public string sprite { get; set; }
    public string itemName { get; set; }
    public string description { get; set; }
    public int maxSize{ get; set; }

    public Item()
    {

    }

    public Item(string itemName, string description, int maxsize, ItemType type, string sprite)
    {
        this.itemName = itemName;
        this.description = description;
        this.maxSize = maxSize;
        this.type = type;
        this.sprite = sprite;
    }

    public abstract void Use();

    public virtual string GetTooltip()
    {
        return null;
    }


    
}
