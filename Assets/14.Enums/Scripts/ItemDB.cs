using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<ItemEnum> itemDB = new List<ItemEnum>();

    private void Start()
    {
        itemDB[0].Action();
        itemDB[1].Action();

    }
}
