using UnityEngine;
using UnityEngine.UI;
public class ChoiceLevel : MonoBehaviour
{
    [SerializeField] private LevelDataBundle _levelDataBundle;
    [SerializeField] private LevelData _selectedLevel;

    private void Start()
    {
        _selectedLevel = _levelDataBundle.Levels[0];
    }
    public void Choice(Dropdown dropdown)
    {
        _selectedLevel = _levelDataBundle.Levels[dropdown.value];
    }
    public LevelData GetSelectedlevel()
    {
        return _selectedLevel;
    }
}
