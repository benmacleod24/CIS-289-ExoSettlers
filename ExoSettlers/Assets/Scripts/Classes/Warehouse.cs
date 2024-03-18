using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;
using System.Linq;

/**
 * Warehouse class will be the root for all warehouses.
 */
[Serializable]
public class Warehouse
{
    public readonly string warehouseId;
    public string warehouseName;
    private int warehouseCapacity;

    public Warehouse(string warehouseId)
    {
        this.warehouseId = warehouseId;
        this.warehouseCapacity = 0;
        this.warehouseName = string.Empty;

        // Initalize the warehouse from the id.
        this.initalizeWarehouse();
    }

    private void initalizeWarehouse()
    {
        // Here we will search a json file, for the warehouse ID and it's data.
        string json = File.ReadAllText(Application.streamingAssetsPath + "/Config/warehouses.json");
        // Parse the json into a dictionary that contains another dictionary.
        Dictionary<string, Dictionary<string, string>> warehouses = JsonConvert.DeserializeObject < Dictionary<string, Dictionary<string, string>>>(json);

        // The warehouse config data from the json file.
        Dictionary<string, string> warehouseData = warehouses[this.warehouseId];

        this.warehouseName = warehouseData["warehouseName"];
        this.warehouseCapacity = int.Parse(warehouseData["warehouseCapacity"]);

    }
}
