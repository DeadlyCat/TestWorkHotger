using UnityEngine;
[CreateAssetMenu(fileName = "newLevelData", menuName = "LevelData", order = 1)]
public class LevelData : ScriptableObject
{
    [SerializeField] private float _startSpeed;
    [SerializeField] private float _speedStep;
    [SerializeField] private float _timeRasingSpeed;
    [SerializeField] private float _stepSpawnBox;

    public float StartSpeed => _startSpeed;
    public float SpeedStep => _speedStep;
    public float TimeRasingSpeed => _timeRasingSpeed;
    public float StepSpawnBox => _stepSpawnBox;
}
