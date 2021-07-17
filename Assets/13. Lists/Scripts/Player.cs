using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameItem[] inventory =  new GameItem[10];
    private ItemDatabase _itemDatabase;

    private void Start()
    {
        _itemDatabase = GameObject.Find("ItemDB").GetComponent<ItemDatabase>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _itemDatabase.AddItem(0, this);
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            _itemDatabase.RemoveItem(0, this);
        }
    }
}
