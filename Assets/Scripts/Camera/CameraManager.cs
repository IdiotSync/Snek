using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CameraManager : MonoBehaviour
{
    private GameObject MainPlayer;

    public void SetCamera(GameObject MainPlayer)
    {
        Vector3 initPos = MainPlayer.transform.position;
        initPos.z = -10;
        transform.position = initPos;
        transform.parent = MainPlayer.transform;
    }
}
