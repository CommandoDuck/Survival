using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;

public class ItemValues
 {

    [XmlAttribute("name")]
    public string name;

    [XmlElement("Description")]
    public string description;
    

}
