using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class ItemReader : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    var itemContainer = ItemDataContainer.Load(Path.Combine(Application.dataPath, "Resources/items.xml"));
        Debug.Log(itemContainer.Items);
        foreach(Item item in itemContainer.Items)
        {
            Debug.Log(item.name);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
