
public struct LevelPointsData 
{
    public int NumberAttempts { get; private set; }
    public float TimeLive { get; private set; }
    public void SetTimeLive(float number)
    {
        TimeLive = number;
    }
    public void SetAttempts(int number)
    {
        NumberAttempts = number;
    }
}
