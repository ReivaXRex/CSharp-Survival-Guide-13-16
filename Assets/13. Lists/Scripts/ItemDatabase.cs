using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<GameItem> itemDatabase = new List<GameItem>();

    public void AddItem(int itemID, Player player)
    {
        foreach (var item in itemDatabase)
        {
            if (item.itemID == itemID)
            {
                Debug.Log("We have a match!");
                player.inventory[0] = item;
                return;
            }
        }
        Debug.Log("Item doesn't exist");
    }

    public void RemoveItem(int itemID, Player player)
    {
        foreach (var item in itemDatabase)
        {
            if (item.itemID == itemID)
            {
                Debug.Log("We have a match!");
                player.inventory[0] = null;                
            }
        }
      
    }
}
