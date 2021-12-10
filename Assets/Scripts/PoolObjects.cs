using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class PoolObjects : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private int _count;
    [SerializeField] private List<GameObject> _pool;
    public List<GameObject> Pool => _pool;
    private void Awake()
    {
        _pool = new List<GameObject>();
        FilingPool(_count);
    }
    private void FilingPool(int count)
    {
        GameObject instObj;
        for (int i = 0; i < count; i++)
        {
            instObj = Instantiate(_prefab, transform);
            instObj.SetActive(false);
            _pool.Add(instObj);
        }
    }
    public void DeactivePoolObject()
    {
        for (int i = 0; i < _count; i++)
        {
            _pool[i].SetActive(false);
        }
    }
    public GameObject GetPooledObject()
    {
        for (int i = 0; i < _count; i++)
        {
            if (_pool[i].activeInHierarchy == false)
            {
                return _pool[i];
            }
        }
        return null;
    }
}
