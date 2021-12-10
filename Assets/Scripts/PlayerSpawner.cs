using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Transform _spawnPoint;

    private GameObject _player;
    private void Start ()
    {
        if(_spawnPoint == null)
        {
            _spawnPoint = transform;
        }
    }
    public void Spawn()
    {
        _player = Instantiate(_prefab, _spawnPoint);
        _player.SetActive(true);
    }
    public void PlayerEnable(bool statys)
    {
        _player.SetActive(statys);
    }
}
