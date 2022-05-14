using System;
using UnityEngine;

namespace Intersection.Core
{
    [Serializable]
    public struct Point
    {
        public Vector3 position;
    }
    
    [Serializable]
    public struct Box
    {
        public Vector3 min;
        public Vector3 max;
    }

    [Serializable]
    public struct Sphere
    {
        public float x;
        public float y;
        public float z;
        public float radius;

        public Sphere(Vector3 position, float radius)
        {
            this.radius = radius;
            x = position.x;
            y = position.y;
            z = position.z;
        }
    }

    [Serializable]
    public struct Point2D
    {
        public Vector2 position;
    }
    
    [Serializable]
    public struct Box2D
    {
        public Vector2 min;
        public Vector2 max;
    }

    [Serializable]
    public struct Circle2D
    {
        public float x;
        public float y;
        public float radius;
    }
}