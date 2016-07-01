using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public static class ItemReader {

	// Use this for initialization
	public static ItemDataContainer GetData () {
	    var itemContainer = ItemDataContainer.Load(Path.Combine(Application.dataPath, "Resources/items.xml"));
        
   
        return itemContainer;
    }

}
