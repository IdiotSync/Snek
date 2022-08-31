using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public int colIndex;
    public int rowIndex;
    public TileSO tileSO;
    public GameManager gameManager;

    private void Awake()
    {
    }
    void Update()
    {
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            ApplyTile(col.gameObject);
        }
    }
    
    void ApplyTile(GameObject mainPlayer)
    {
        ControlsScript controlsScript = mainPlayer.GetComponent<ControlsScript>() as ControlsScript;
        PlayerManager playerManager = mainPlayer.GetComponent<PlayerManager>() as PlayerManager;
        switch (tileSO.type)
        {
            case "dirt":
                controlsScript.speed = tileSO.speed;
                break;
            case "grass":
                controlsScript.speed = tileSO.speed;
                break;
            case "spawner":
                break;
            default:
                break;
        }
    }
}
