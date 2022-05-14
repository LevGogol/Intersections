using Intersection.Core;
using UnityEngine;

namespace Intersection
{
    public class BoxIntersector : Intersector
    {
        [SerializeField] private Vector3 _size;
        
        private Box _box;
        private Transform _transform;

        public Vector3 GetSize()
        {
            return Vector3.Scale(_size, _transform.localScale);
        } 

        public Box GetBox()
        {
            _box.min = _transform.position - GetSize();
            _box.max = _transform.position + GetSize();

            return _box;
        }
        
        private void Start()
        {
            _transform = transform;
            
            IntersectionSystem.Add(this);
        }

        protected override bool IntersectWithBox(Box box)
        {
            return MathIntersection.IsIntersect(GetBox(), box);
        }

        protected override bool IntersectWithSphere(Sphere sphere)
        {
            return MathIntersection.IsIntersect(sphere, GetBox());
        }

        protected override bool IntersectWithPoint(Point point)
        {
            return MathIntersection.IsIntersect(point, GetBox());
        }
        
        public void OnDrawGizmosSelected()
        {
            var size = Vector3.Scale(_size, transform.localScale);
            Gizmos.DrawWireCube(transform.position, size);
        }
    }
}