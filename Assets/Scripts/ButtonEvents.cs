using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class ButtonEvents : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    private UnityAction _moveDown;
    private UnityAction _moveUp;

    private PlayerBehaviour _playerBehavior;

    private void OnEnable()
    {
        _playerBehavior = FindObjectOfType<PlayerBehaviour>();
        _moveDown += _playerBehavior.MoveDown;
        _moveUp += _playerBehavior.MoveUp;
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        _moveUp.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _moveDown.Invoke();
    }
}
