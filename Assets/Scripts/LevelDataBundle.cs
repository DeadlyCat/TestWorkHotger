using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "newLevelBundle", menuName = "LevelBundle", order = 1)]
public class LevelDataBundle : ScriptableObject
{
    [SerializeField] private List<LevelData> _levels;
    public List<LevelData> Levels => _levels;
}
