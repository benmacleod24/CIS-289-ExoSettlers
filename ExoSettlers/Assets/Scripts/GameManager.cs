using Assets.Scripts.Classes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Stores the active session of the game.
    Session activeSession;
    Warehouse warehouse;

    // Start is called before the first frame update
    void Start()
    {
        warehouse = new Warehouse("base-warehouse");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
