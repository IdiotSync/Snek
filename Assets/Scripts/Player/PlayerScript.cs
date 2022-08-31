using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerScript : MonoBehaviour
{
    public int rowIndex;
    public int colIndex;
    public GameManager gameManager;

    public void Awake()
    {
        gameManager = gameObject.GetComponent<GameManager>();
    }
    public void setPosition(Vector2 Position)
    {
        rowIndex = gameManager.tilesMap.WorldToCell(Position).x;
        colIndex = gameManager.tilesMap.WorldToCell(Position).y;
    }
    public Vector3Int getTilePosition()
    {
        return new Vector3Int(rowIndex, colIndex, 0);
    }
}
