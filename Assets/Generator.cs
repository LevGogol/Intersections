using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    [HideInInspector] public List<Transform> Objects;
    
    [SerializeField] private GameObject _gameObjectTemplate;
    [SerializeField] private int _count;
    [SerializeField] private Vector3 _offset;

    private void Awake()
    {
        for (int i = 0; i < _count; i++)
        {
            Objects.Add(Instantiate(_gameObjectTemplate, _offset * (i + 1), Quaternion.identity, transform).transform);
        }
    }
}
