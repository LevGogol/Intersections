using System;
using Intersection.Core;
using UnityEngine;

public class TestWithCore : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Generator _generator;

    private Sphere _cashSphere;
    private Sphere _cashSphere2;
    private Transform[] _objects;

    private void Start()
    {
        _objects = _generator.Objects.ToArray();
    }

    void FixedUpdate()
    {
        var sphere = new Sphere(_player.position, 1f);

        for (int i = 0; i < _objects.Length; i++)
        {
            var sphere2 = new Sphere(_objects[i].position, 1f);
        
            if (MathIntersection.IsIntersect(sphere, sphere2))
            {
                print("Hi");
            }
        }
    }
}