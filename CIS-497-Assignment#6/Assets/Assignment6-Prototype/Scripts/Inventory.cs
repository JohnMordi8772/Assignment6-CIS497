﻿/*
 John Mordi
 Assignment #6
 Example of serialization.
		 */
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    [SerializeField] private InventoryItem item;
    public List<InventoryItem> inventoryList;

    // Use this for initialization
    void Start()
    {
        item = new InventoryItem();
        inventoryList = new List<InventoryItem>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
