using System;
using Intersection.Core;
using UnityEngine;

namespace Intersection
{
    public abstract class Intersector : MonoBehaviour
    {
        public Action<Intersector> Intersected;
        protected abstract bool IntersectWithBox(Box box);
        protected abstract bool IntersectWithSphere(Sphere sphere);
        protected abstract bool IntersectWithPoint(Point point);

        public void Registrate()
        {
            IntersectionSystem.Registrate(this);
        }

        public void Intersect(Intersector intersector)
        {
            Intersected.Invoke(intersector);
        }
        
        public bool IntersectWithY(Intersector Y)
        {
            switch (Y)
            {
                case BoxIntersector boxIntersector:
                    return IntersectWithBox(boxIntersector.GetBox());
                case SphereIntersector sphereIntersector:
                    return IntersectWithSphere(sphereIntersector.GetSphere());
                case PointIntersector pointIntersector:
                    return IntersectWithPoint(pointIntersector.GetPoint());
                default:
                    return false;
            }
        }
    }
}