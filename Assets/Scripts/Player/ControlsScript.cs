using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ControlsScript : MonoBehaviour
{    
    private  enum direction { NONE, LEFT, RIGHT, DOWN, UP };
    private direction move = direction.NONE;
    private direction moveAfter = direction.NONE;
    public float speed = 20;
    public Vector2 target = Vector2.zero;
    private PlayerScript playerScript;
    public GameManager gameManager;

    private void Awake()
    {
        playerScript = gameObject.GetComponent<PlayerScript>();
    }

    private bool validTarget(direction dir)
    {
        Debug.Log(dir);
        Debug.Log(playerScript.rowIndex + " / " + playerScript.colIndex);
        switch (dir)
        {
            case direction.LEFT:
                if (gameManager.tilesMap.GetTile(new Vector3Int(playerScript.rowIndex - 1, playerScript.colIndex)) != null)
                    return true;
                else
                    return false;
            case direction.UP:
                if (gameManager.tilesMap.GetTile(new Vector3Int(playerScript.rowIndex, playerScript.colIndex + 1)) != null)
                    return true;
                else
                    return false;
            case direction.DOWN:
                if (gameManager.tilesMap.GetTile(new Vector3Int(playerScript.rowIndex, playerScript.colIndex - 1)) != null)
                    return true;
                else
                    return false;
            case direction.RIGHT:
                if (gameManager.tilesMap.GetTile(new Vector3Int(playerScript.rowIndex + 1, playerScript.colIndex)) != null)
                    return true;
                else
                    return false;
            case direction.NONE:
                return true;
            default:
                return false;
        }
    }

    void Update()
    {
        if (move != direction.NONE)
        {
            // register next input
            if (Input.GetKeyDown(KeyCode.DownArrow))
                moveAfter = direction.DOWN;
            else if (Input.GetKeyDown(KeyCode.UpArrow))
                moveAfter = direction.UP;
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
                moveAfter = direction.LEFT;
            else if (Input.GetKeyDown(KeyCode.RightArrow))
                moveAfter = direction.RIGHT;

            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, target, step);
            if ((Vector2)transform.position == target)
            {
                if (moveAfter != direction.NONE) // move to next one
                {
                    move = moveAfter;
                    moveAfter = direction.NONE;
                    if (validTarget(move))
                        setTarget(move);
                }
                else // stop at end of move {
                    move = direction.NONE;
            }
        }
        else // new move
        {
            if (Input.GetKeyDown(KeyCode.DownArrow))
                move = direction.DOWN;
            else if (Input.GetKeyDown(KeyCode.UpArrow))
                move = direction.UP;
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
                move = direction.LEFT;
            else if (Input.GetKeyDown(KeyCode.RightArrow))
                move = direction.RIGHT;
            if ((move != direction.NONE) && validTarget(move))
                setTarget(move);
        }
    }

    private void setTarget(direction move)
    {
        target = playerScript.transform.position;
        switch (move)
        {
            case direction.NONE:
                break;
            case direction.LEFT:
                target = (Vector2)transform.position + (Vector2.left);
                break;
            case direction.RIGHT:
                target = (Vector2)transform.position + (Vector2.right);
                break;
            case direction.UP:
                target = (Vector2)transform.position + (Vector2.up);
                break;
            case direction.DOWN:
                target = (Vector2)transform.position + (Vector2.down);
                break;
            default:
                break;

        }
        playerScript.setPosition(target);
        return;
    }
}
