using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsScript : MonoBehaviour
{    
    public  enum direction { NONE, LEFT, RIGHT, DOWN, UP };
    public direction move = direction.NONE;
    public direction moveAfter = direction.NONE;
    public float speed = 20;
    public Vector2 target = Vector2.zero;
    public SpriteRenderer SpriteRenderer;

    void Start()
    {
        SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
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
                    setTarget(move);
                }
                else // stop at end of move
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
            setTarget(move);
        }
    }

    private void setTarget(direction move)
    {
        target = Vector2.zero;
        switch (move)
        {
            case direction.NONE:
                break;
            case direction.LEFT:
                target = (Vector2)transform.position + (Vector2.left * transform.localScale.x);
                break;
            case direction.RIGHT:
                target = (Vector2)transform.position + (Vector2.right * transform.localScale.x);
                break;
            case direction.UP:
                target = (Vector2)transform.position + (Vector2.up * transform.localScale.y);
                break;
            case direction.DOWN:
                target = (Vector2)transform.position + (Vector2.down * transform.localScale.y);
                break;
            default:
                break;

        }
        return;
    }
}
