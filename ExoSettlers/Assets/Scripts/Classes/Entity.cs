using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Entity
{
    public string entityName;
    public string entityId;
    public int entityHealth;

    public Entity(string entityId, string entityName = "", int entityHealth = 100)
    {
        this.entityId = entityId;
        this.entityHealth = entityHealth;
        this.entityName = entityName;
    }
}
