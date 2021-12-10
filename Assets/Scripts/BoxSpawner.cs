using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    [SerializeField] private PoolObjects _poolObjects;
    [SerializeField] private Transform _bottomBorder;
    [SerializeField] private Transform _topBorder;
    [SerializeField] private ChoiceLevel _choiceLevel;
    [SerializeField] private Transform _playerSpawnPos;
    [SerializeField] private int _count;

    private LevelData _level;
    private float _stepSpawn;
    private Transform _lastBox;

    public static BoxSpawner boxSpawner;

    private void Start()
    {
        boxSpawner = this;
    }
    public void StartSpawn()
    {
        _level = _choiceLevel.GetSelectedlevel();
        _lastBox = _playerSpawnPos;
        _stepSpawn = _level.StepSpawnBox;
        SpawnGroup(_count);
    }
    public static BoxSpawner GetInstance()
    {
        return boxSpawner;
    }
    public void Spawn()
    {
        NextSpawnPos(_stepSpawn);
        GameObject spawnObj = _poolObjects.GetPooledObject();
        spawnObj.SetActive(true);
        spawnObj.transform.position = GeneratePosition(_bottomBorder.position.y+1, _topBorder.position.y-1, _lastBox.position.x);
        _lastBox = spawnObj.transform;
    }
    private Vector3 GeneratePosition(float minY,float maxY,float x)
    {
        float y = Random.Range(minY, maxY);
        
        return new Vector3(NextSpawnPos(_stepSpawn), y);
    }
    private float NextSpawnPos(float step)
    {
        return _lastBox.position.x +  step;
    }
    private void SpawnGroup(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Spawn();
        }
    }
  
}