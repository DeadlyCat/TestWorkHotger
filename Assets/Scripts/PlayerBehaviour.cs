using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerBehaviour : MonoBehaviour
{
    private Rigidbody2D _rigidbody;

    private void OnEnable()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    public void MoveUp()
    {
        Move(-1);
    }
    public void MoveDown()
    {
        Move(1);
    }
    private void Move(float scale)
    {
        _rigidbody.gravityScale = scale;
    }
    public void Die()
    {
        this.gameObject.SetActive(false);
    }
}
