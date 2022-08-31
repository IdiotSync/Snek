using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInit : MonoBehaviour
{
    MapManager mapManager;
    PlayerSpawner playerSpawner;

    public void Awake()
    {
        mapManager = gameObject.GetComponent<MapManager>();
        playerSpawner = gameObject.GetComponent<PlayerSpawner>();
    }
    public void Start()
    {
        mapManager.SpawnMap();
        playerSpawner.SpawnPlayer();
    }
}
