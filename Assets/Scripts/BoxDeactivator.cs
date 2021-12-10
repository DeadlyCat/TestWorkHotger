using UnityEngine;
public class BoxDeactivator : MonoBehaviour
{
    [SerializeField] private BoxSpawner _boxSpawner;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Box box)){
            box.Die();
            _boxSpawner.Spawn();
        }
    }
}
