using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileScript : MonoBehaviour
{
    public int colIndex;
    public int rowIndex;
    public TileSO tileSO;
    public TileBase tileBase;
    public GameManager gameManager;

    private void Awake()
    {
    }
    void Update()
    {
    }
    public void initTile(GameManager sourceGameManager, Vector2 initPos, TileSO sourceTileSO, TileBase sourceTileBase)
    {
        tileBase = sourceTileBase;
        tileSO = sourceTileSO;
        gameManager = sourceGameManager;
        rowIndex = (int) initPos.x;
        colIndex = (int) initPos.y;
        return;
    }
}
