using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "LevelSO", menuName = "ScriptableObjects/LevelSO", order = 1)]
public class LevelSO : ScriptableObject
{
    public List<TileSO> Ground = new List<TileSO>();

}