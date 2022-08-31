using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Tilemaps;

public class PlayerSpawner : MonoBehaviour
{
    public PlayerSO PlayerSO;
    private GameObject MainPlayer;
    [SerializeField]
    private Tilemap tilesMap;

    public void Awake()
    {
        //SpawnPlayer();
    }
    public void SpawnPlayer()
    {
        Vector2 playerPos = new Vector2();
        playerPos.x = tilesMap.origin.x / 2;
        playerPos.y = tilesMap.origin.y / 2;
        MainPlayer = Instantiate(PlayerSO.prefab, playerPos , Quaternion.identity);
        MainPlayer.name = PlayerSO.prefabName;
    }
    public GameObject GetMainPlayer()
    {
        return MainPlayer;
    }
}