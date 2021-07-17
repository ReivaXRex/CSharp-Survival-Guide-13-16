using System.Collections.Generic;
using UnityEngine;

public class ItemDBi : MonoBehaviour
{
    // public List<ItemDi> _itemList = new List<ItemDi>();

    public Dictionary<int, ItemDi> itemDictionary = new Dictionary<int, ItemDi>();

    private void Start()
    {
        ItemDi sword = new ItemDi();
        sword._name = "Sword";
        sword._id = 0;

        ItemDi bread = new ItemDi();
        bread._name = "Bread";
        bread._id = 1;

        ItemDi cape = new ItemDi();
        cape._name = "Cape";
        cape._id = 2;

        // _itemList.Add(sword);
        itemDictionary.Add(0, sword);
        itemDictionary.Add(1, bread);
        itemDictionary.Add(2, cape);

        #region Check if Key Exists

        if (itemDictionary.ContainsKey(60))
        {
            Debug.Log("Key was found");
            var randomItem = itemDictionary[60];
        }
        else
        {
            Debug.Log("Item does not exist!");
        }

        #endregion Check if Key Exists

        #region Loop Entire Dictionary

        foreach (KeyValuePair<int, ItemDi> item in itemDictionary)
        {
            Debug.Log("Key: " + item.Key);
            Debug.Log("Value: " + item.Value);
        }

        #endregion Loop Entire Dictionary

        #region Loop using Keys

        foreach (var key in itemDictionary.Keys)
        {
            Debug.Log("Key: " + key);
        }

        #endregion Loop using Keys

        #region Loop Using Values

        foreach (ItemDi item in itemDictionary.Values)
        {
            Debug.Log("Item Name: " + item.name);
        }

        #endregion Loop Using Values
    }
}