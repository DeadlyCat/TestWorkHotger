using UnityEngine;
using UnityEngine.UI;
public class ShowLevelResult : MonoBehaviour
{
    [SerializeField] private LevelPoints _levelPoints;
    [SerializeField] private Text _timeLive;
    [SerializeField] private Text _numberAttempts;
    public void Show()
    {
        _timeLive.text = _levelPoints.GetData().TimeLive.ToString();
        _numberAttempts.text = _levelPoints.GetData().NumberAttempts.ToString();
    }
}
