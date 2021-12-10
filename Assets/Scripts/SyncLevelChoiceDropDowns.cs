using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class SyncLevelChoiceDropDowns : MonoBehaviour
{
    [SerializeField] private Dropdown[] _dropDowns;

    private UnityAction<int> ChangeItem;
    private void Start()
    {
        ChangeItem += Sync;
        foreach (Dropdown dropdown in _dropDowns)
        {
            dropdown.onValueChanged.AddListener(Sync);
        }
    }
    private void Sync(int index)
    {
        foreach (Dropdown dropdown in _dropDowns)
        {
            dropdown.value = index;
        }
    }
}
