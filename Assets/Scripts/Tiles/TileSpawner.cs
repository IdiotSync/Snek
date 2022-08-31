using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    public TileSO TileDirt;
    public TileSO TileGrass;
    public TileSO TileLanding;
    private GameObject MainTile;
    public List<List<TileScript>> Grid = new List<List<TileScript>>();
    public void Awake()
    {
        SpawnTiles();
    }
    public void SpawnTiles()
    {
        /*foreach (List<TileScript> col in Grid)
        {
            foreach (TileScript row in col)
            {
                Vector2 current = new Vector2(row.rowIndex, row.colIndex);
                Vector2 spawnPos = (current) * 1f;
                MainTile = Instantiate(row.TileSO.prefab, spawnPos, Quaternion.identity);
                MainTile.name = row.TileSO.prefabName;
                MainTile.GetComponent<SpriteRenderer>().sprite = row.TileSO.sprite;
            }
        }*/
        /*MainTile = Instantiate(TileSO.prefab, Vector2.zero, Quaternion.identity);
        MainTile.name = TileSO.prefabName;
        MainTile.GetComponent<SpriteRenderer>().sprite = TileSO.sprite;*/
    }
}
