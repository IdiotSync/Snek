using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CameraScript : MonoBehaviour
{
    public Tilemap tilesMap;
    public PlayerScript player;
    void Start()
    {
    }

    public void SetCamera()
    {
        Debug.Log(tilesMap.size);
        Debug.Log(tilesMap.cellBounds);
        Debug.Log(tilesMap.localBounds);
        Debug.Log(tilesMap.cellSize);
        transform.position = new Vector3(tilesMap.size.x / 2, tilesMap.size.y / 2, -10);
    }
}
