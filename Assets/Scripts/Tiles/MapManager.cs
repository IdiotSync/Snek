using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapManager : MonoBehaviour
{
    public PlayerSO playerSO;
    public GameObject tilesFolder;
    public List<Vector2> spawners = new List<Vector2>();
    [SerializeField]
    private List<TileSO> tilesSO;
    private GameManager gameManager;
    private List<GameObject> tilesObjs;
    private Dictionary<TileBase, TileSO> tilesDic;
    private TileBase[] tilesCells;


    void Awake()
    {
        gameManager = gameObject.GetComponent<GameManager>();
        tilesObjs = new List<GameObject>();
        tilesDic = new Dictionary<TileBase, TileSO>();
        foreach (TileSO tileSO in tilesSO)
            foreach (TileBase tileBase in tileSO.tiles)
            {
                tilesDic.Add(tileBase, tileSO);
            }
    }
    public void SpawnMap()
    {
        BoundsInt bounds = gameManager.tilesMap.cellBounds;
        tilesCells = gameManager.tilesMap.GetTilesBlock(bounds);

        for (int x = 0; x < bounds.size.x; x++)
        {
            for (int y = 0; y < bounds.size.y; y++)
            {
                TileBase cell = tilesCells[x + y * bounds.size.x];
                if (cell != null)
                {
                    Vector2 newPos = new Vector2(x, y);
                    GameObject newTile = Instantiate(tilesDic[cell].prefab, newPos, Quaternion.identity);
                    newTile.transform.parent = tilesFolder.transform;
                    newTile.name = "["+x+","+y+"] " + tilesDic[cell].prefabName;
                    tilesObjs.Add(newTile);
                    if (tilesDic[cell].prefabName == "Spawner")
                    {
                        spawners.Add(new Vector2(x, y));
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {


    }
    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.gameObject.name + " : " + gameObject.name + " : " + Time.time);
    }
}
