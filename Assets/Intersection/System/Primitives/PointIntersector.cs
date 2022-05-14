using Intersection.Core;
using UnityEditor;
using UnityEngine;

namespace Intersection
{
    public class PointIntersector : Intersector
    {
        [SerializeField] private float _gizmoPointSize = 0.1f;

        private Point _point;
        private Transform _transform;

        public Point GetPoint()
        {
            _point.position = _transform.position;
            return _point;
        }

        private void Start()
        {
            _transform = transform;

            IntersectionSystem.Add(this);
        }

        protected override bool IntersectWithBox(Box box)
        {
            return MathIntersection.IsIntersect(GetPoint(), box);
        }

        protected override bool IntersectWithSphere(Sphere sphere)
        {
            return MathIntersection.IsIntersect(GetPoint(), sphere);
        }

        protected override bool IntersectWithPoint(Point point)
        {
            return false;
        }

        public void OnDrawGizmos()
        {
            Gizmos.DrawSphere(transform.position, _gizmoPointSize);
        }
    }
}