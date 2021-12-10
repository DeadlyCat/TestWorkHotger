using UnityEngine;

public abstract class Move : MonoBehaviour
{
    [SerializeField] protected Vector3 _diraction;
    protected abstract void Moving(Vector3 dir, float speed);
}
