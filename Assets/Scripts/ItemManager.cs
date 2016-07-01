using UnityEngine;
using System.Collections;
using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public enum Category { EQUIPMENT, WEAPON, CONSUMABLE}

[XmlRoot("ItemManager")]
public class ItemManager : MonoBehaviour {

    public ItemType type;
    public Category category;
    public string sprite;
    public string itemName;
    public string description;
    public int health;
    public int mana;


    public void CreateItem()
    {
        ItemContainer itemContainer = new ItemContainer();

        Type[] itemTypes = { typeof(Consumable) };

        FileStream fs = new FileStream(Path.Combine(Application.streamingAssetsPath, "items.xml"), FileMode.Open);

        XmlSerializer serializer = new XmlSerializer(typeof(ItemContainer), itemTypes);

        itemContainer = (ItemContainer)serializer.Deserialize(fs);

        serializer.Serialize(fs, itemContainer);

        fs.Close();

        switch(category)
        {
            case Category.CONSUMABLE:
                itemContainer.Consumables.Add(new Consumable(itemName, description, itemTypes, sprite, health, mana));
                break;
        }

        fs = new FileStream(Path.Combine(Application.streamingAssetsPath, "items.xml"), FileMode.Create);
        serializer.Serialize(fs, itemContainer);
        fs.Close();
    }
}
