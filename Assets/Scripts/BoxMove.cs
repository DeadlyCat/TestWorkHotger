using UnityEngine;

public class BoxMove : Move
{
    [SerializeField] private LevelData _level;

    private SpeedCalculator _speedCalculator;

    private void Start()
    {
        _speedCalculator = FindObjectOfType<SpeedCalculator>();
    }
    protected override void Moving(Vector3 dir, float speed)
    {
        transform.position += dir * speed * Time.fixedDeltaTime;
    }
    private void FixedUpdate()
    {
        Moving(_diraction, _speedCalculator.Speed);
    }
}
