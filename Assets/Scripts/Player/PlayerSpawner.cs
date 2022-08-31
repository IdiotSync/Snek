using UnityEngine;
using System.Collections.Generic;

public class PlayerSpawner : MonoBehaviour
{
    public PlayerSO PlayerSO;
    private GameObject MainPlayer;

    public void Awake()
    {
        SpawnPlayer();
    }
    public void SpawnPlayer()
    {
        MainPlayer = Instantiate(PlayerSO.prefab, Vector2.zero, Quaternion.identity);
        MainPlayer.name = PlayerSO.prefabName;
    }
    public GameObject GetMainPlayer()
    {
        return MainPlayer;
    }
}