using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("ItemCollection")]
public class ItemDataContainer {

    [XmlArray("Items"), XmlArrayItem("Item")]
    public List<ItemData> ItemData = new List<ItemData>();
    //public ItemValues[] Items;

    public void Save(string path)
    {
        var serializer = new XmlSerializer(typeof(ItemDataContainer));
        using (var stream = new FileStream(path, FileMode.Create))
        {
            serializer.Serialize(stream, this);
        }
    }

    public static ItemDataContainer Load(string path)
    {
        var serializer = new XmlSerializer(typeof(ItemDataContainer));
        using (var stream = new FileStream(path, FileMode.Open))
        {
            return serializer.Deserialize(stream) as ItemDataContainer;
        }
    }
}
