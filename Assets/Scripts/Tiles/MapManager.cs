using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapManager : MonoBehaviour
{
    [SerializeField]
    private TilemapCollider2D tileColliders;
    [SerializeField]
    private Tilemap tileMap;
    [SerializeField]
    private List<TileSO> tileData;
    private List<GameObject> tileObjs;
    private Dictionary<TileBase, TileSO> tileDic;
    private PlayerScript player;
    private TileBase[] tileCells;
    void Awake()
    {
        tileObjs = new List<GameObject>();
        tileDic = new Dictionary<TileBase, TileSO>();
        foreach (TileSO tileSO in tileData)
            foreach (TileBase tileBase in tileSO.tiles)
            {
                tileDic.Add(tileBase, tileSO);
            }
    }
    void Start()
    {
        BoundsInt bounds = tileMap.cellBounds;
        tileCells = tileMap.GetTilesBlock(bounds);
        player = gameObject.GetComponent<PlayerSpawner>().GetMainPlayer().GetComponent<PlayerScript>();


        /*BoundsInt bounds = tileMap.cellBounds;
        TileBase[] allTiles = tileMap.GetTilesBlock(bounds);

        for (int x = 0; x < bounds.size.x; x++)
        {
            for (int y = 0; y < bounds.size.y; y++)
            {
                TileBase tile = allTiles[x + y * bounds.size.x];
                if (tile != null)
                {
                    Debug.Log("x:" + x + " y:" + y + " tile:" + tile.name);
                }
                else
                {
                    Debug.Log("x:" + x + " y:" + y + " tile: (null)");
                }
            }
        }*/
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3Int gridPos = tileMap.WorldToCell(Vector2.zero);
        TileBase clickedTile = tileMap.GetTile<TileBase>(gridPos);
        Vector3Int playerPos = tileMap.WorldToCell((Vector2) player.transform.position);
        TileBase clickedPlayer = tileMap.GetTile<TileBase>(playerPos);
        TileBase Tb = tileCells[0];

        //TileBase tile = allTiles[x + y * bounds.size.x];
        //Debug.Log("PLAYER " + clickedPlayer + " " + playerPos);
        Debug.Log("Tile2 " + playerPos);
        Debug.Log("Tile " + Tb);
        Debug.Log("Tile " + clickedTile);
        Debug.Log("Tile " + clickedPlayer);
        Debug.Log("Tile " + tileDic[clickedPlayer] + " " + gridPos);

        GameObject newTile = Instantiate(tileDic[clickedTile].prefab, Vector2.zero, Quaternion.identity);
        newTile.name = tileDic[clickedTile].prefabName;
        tileObjs.Add(newTile);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
    }
}
