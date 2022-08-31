using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(fileName = "TileSO", menuName = "ScriptableObjects/TileSO", order = 1)]
public class TileSO : ScriptableObject
{
    public GameObject prefab;
    public string prefabName;
    public string type;
    public TileBase[] tiles;
    public float speed;
} 