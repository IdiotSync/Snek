using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour
{
    public GameObject cameraObj;
    [SerializeField]
    public Tilemap tilesMap;
    MapManager mapManager;
    PlayerManager playerManager;
    CameraManager cameraManager;

    public void Awake()
    {
        mapManager = gameObject.GetComponent<MapManager>();
        playerManager = gameObject.GetComponent<PlayerManager>();
        cameraManager = cameraObj.GetComponent<CameraManager>();
    }
    public void Start()
    {
        mapManager.SpawnMap();
        playerManager.SpawnPlayer(mapManager.spawners[0]);
        cameraManager.SetCamera(playerManager.GetMainPlayer());
    }
    public MapManager getMapManager()
    {
        return mapManager;
    }
}
