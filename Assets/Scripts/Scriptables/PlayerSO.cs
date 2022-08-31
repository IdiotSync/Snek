using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSO", menuName = "ScriptableObjects/PlayerSO", order = 1)]
public class PlayerSO : ScriptableObject
{
    public GameObject prefab;
    public string prefabName;
}