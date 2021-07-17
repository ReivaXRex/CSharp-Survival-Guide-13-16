using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemEnum 
{
    public string itemName;
    public int id;
    public Sprite itemIcon;

    public enum ItemType
    { 
        None,
        Weapon,
        Consumable
    }

    public ItemType itemType;

    public void Action()
    {
        switch (itemType)
        {
            case ItemType.None:
                break;
            case ItemType.Weapon:
                Debug.Log("This is a " + itemType);
                break;
            case ItemType.Consumable:
                Debug.Log("This is a " + itemType + " item.");
                break;
            default:
                break;
        }

    }
}
