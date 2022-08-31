using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Tilemaps;

public class PlayerManager : MonoBehaviour
{
    public PlayerSO playerSO;
    private GameObject mainPlayer;
    private PlayerScript playerScript;
    private ControlsScript controlScript;
    private GameManager gameManager;

    public void Awake()
    {
        gameManager = gameObject.GetComponent<GameManager>();
    }

    public void SpawnPlayer(Vector2 initPos)
    {
        mainPlayer = Instantiate(playerSO.prefab, initPos, Quaternion.identity);
        mainPlayer.name = playerSO.prefabName;
        setObjectsManager();
        playerScript.setPosition(initPos);
    }
    public GameObject GetMainPlayer()
    {
        return mainPlayer;
    }
    private void setObjectsManager()
    {
        playerScript = mainPlayer.GetComponent<PlayerScript>();
        controlScript = mainPlayer.GetComponent<ControlsScript>();
        playerScript.gameManager = gameManager;
        controlScript.gameManager = gameManager;
        return;
    }
}