using UnityEngine;
using UnityEngine.UI;
public class MovePlatform : Move
{
    [SerializeField] private ChoiceLevel _choiceLevel;
    [SerializeField] private SpeedCalculator _speedCalculator;
    [SerializeField] private Transform _movable;
    [SerializeField] private int zeroingStep;
    private bool moveEnable = false;
    private void Start()
    {
        if(_movable == null)
        {
            _movable = transform;
        }
    }
    private void FixedUpdate()
    {
        if(moveEnable == true)
        {
            Moving(_diraction, _speedCalculator.Speed);
        }
    }
    protected override void Moving(Vector3 dir, float speed)
    {
        _movable.position += dir * speed * Time.fixedDeltaTime;
        if (Mathf.Abs(_movable.position.x) >= zeroingStep)
        {
            _movable.position = Vector3.zero;
        }
        
    }
    public void MoveEnable(bool statys)
   {
        moveEnable = statys;
   }
}
