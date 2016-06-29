using System.Xml;
using System.Xml.Serialization;

public class ItemData
{
    [XmlAttribute("name")]
    public string Name;

    public string Description;
}
