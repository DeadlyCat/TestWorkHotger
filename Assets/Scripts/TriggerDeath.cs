using UnityEngine;
using UnityEngine.Events;
public class TriggerDeath : MonoBehaviour
{
    private SceneEvents _sceneEvents;
    private void Start()
    {
        _sceneEvents = SceneEvents.Instance();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.TryGetComponent(out PlayerBehaviour player)){
            player.Die();
            _sceneEvents.GameOver();
        }
    }
}
