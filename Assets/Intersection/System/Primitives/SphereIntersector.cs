using Intersection.Core;
using UnityEngine;

namespace Intersection
{
    public class SphereIntersector : Intersector
    {
        [SerializeField] float _radius;

        private Sphere _sphere;
        private Vector3 _position;
        private Transform _transform;

        public Sphere GetSphere()
        {
            _sphere.radius = _radius;
            _position = _transform.position;
            _sphere.x = _position.x;
            _sphere.y = _position.y;
            _sphere.z = _position.z;
            return _sphere;
        }

        private void Start()
        {
            _transform = transform;

            IntersectionSystem.Add(this);
        }

        protected override bool IntersectWithBox(Box box)
        {
            return MathIntersection.IsIntersect(GetSphere(), box);
        }

        protected override bool IntersectWithSphere(Sphere sphere)
        {
            return MathIntersection.IsIntersect(GetSphere(), sphere);
        }

        protected override bool IntersectWithPoint(Point point)
        {
            return MathIntersection.IsIntersect(point, GetSphere());
        }

        public void OnDrawGizmosSelected()
        {
            Gizmos.DrawWireSphere(transform.position, _radius);
        }
    }
}