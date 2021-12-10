using UnityEngine;

public class LevelPoints : MonoBehaviour
{
    private LevelPointsData _levelPointsData;

    private void Start()
    {
        _levelPointsData = new LevelPointsData();
        if(PlayerPrefs.HasKey("Attempts") == true)
        {
            _levelPointsData.SetAttempts(PlayerPrefs.GetInt("Attempts"));
        }
    }
    public void StartCalculateLiveTime()
    {
        _levelPointsData.SetTimeLive(0);
        InvokeRepeating("CalculateLiveTime", 1, 1);
    }
    private void CalculateLiveTime()
    {
        _levelPointsData.SetTimeLive(_levelPointsData.TimeLive + 1);
    }
    public void StopCalculateLiveTime()
    {
        CancelInvoke();
    }

    public LevelPointsData GetData()
    {
        return _levelPointsData;
    }
    public void PlusAttempt()
    {
        _levelPointsData.SetAttempts(_levelPointsData.NumberAttempts + 1);
        PlayerPrefs.SetInt("Attempts", _levelPointsData.NumberAttempts);
    }
    private void OnApplicationQuit()
    {
        PlayerPrefs.DeleteKey("Attempts");
    }
}
