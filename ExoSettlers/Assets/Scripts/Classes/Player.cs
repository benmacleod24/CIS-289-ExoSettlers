using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Entity playerEntity;

    // Start is called before the first frame update
    void Start()
    {
        playerEntity = new Entity("player", entityName: "Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
