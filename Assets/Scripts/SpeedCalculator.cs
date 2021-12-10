using UnityEngine;

public class SpeedCalculator : MonoBehaviour
{
    [SerializeField] private LevelData _level;
    [SerializeField] private ChoiceLevel _choiceLevel;
    public float Speed { get; private set; }
    public void StartCalculate()
    {
        _level = _choiceLevel.GetSelectedlevel();
        Speed = _level.StartSpeed;
        InvokeRepeating("Calculate", _level.TimeRasingSpeed, _level.TimeRasingSpeed);
    }
    private void Calculate()
    {
        Speed += _level.SpeedStep;
    }
    public void Zeroing()
    {
        CancelInvoke();
    }
    
}
