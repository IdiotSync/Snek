using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerScript : MonoBehaviour
{
    public int rowIndex;
    public int colIndex;
    public GameManager gameManager;
    private PlayerSO playerSO;

    public void initPlayer(GameManager sourceGameManager, PlayerSO sourcePlayerSO, Vector2 initPos)
    {
        gameManager = sourceGameManager;
        playerSO = sourcePlayerSO;
        rowIndex = (int) initPos.x;
        colIndex = (int) initPos.y;
        setPosition(new Vector2(rowIndex, colIndex));
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
