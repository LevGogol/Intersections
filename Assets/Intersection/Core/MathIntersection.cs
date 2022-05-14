using System;

namespace Intersection.Core
{
    public static class MathIntersection
    {
        public static bool IsIntersect(Box box1, Box box2)
        {
            return (box1.min.x <= box2.max.x && box1.max.x >= box2.min.x) &&
                   (box1.min.y <= box2.max.y && box1.max.y >= box2.min.y) &&
                   (box1.min.z <= box2.max.z && box1.max.z >= box2.min.z);
        }

        public static bool IsIntersect(Point point, Box box)
        {
            return (point.position.x >= box.min.x && point.position.x <= box.max.x) &&
                   (point.position.y >= box.min.y && point.position.y <= box.max.y) &&
                   (point.position.z >= box.min.z && point.position.z <= box.max.z);
        }

        public static bool IsIntersect(Point point, Sphere sphere)
        {
            var distanceSqr = (point.position.x - sphere.x) * (point.position.x - sphere.x) +
                              (point.position.y - sphere.y) * (point.position.y - sphere.y) +
                              (point.position.z - sphere.z) * (point.position.z - sphere.z);
            return distanceSqr < sphere.radius * sphere.radius;
        }

        public static bool IsIntersect(Sphere sphere1, Sphere sphere2)
        {
            return (sphere1.x - sphere2.x) * (sphere1.x - sphere2.x) +
                   (sphere1.y - sphere2.y) * (sphere1.y - sphere2.y) +
                   (sphere1.z - sphere2.z) * (sphere1.z - sphere2.z) < 
                   (sphere1.radius + sphere2.radius) * (sphere1.radius + sphere2.radius);
        }

        public static bool IsIntersect(Sphere sphere, Box box)
        {
            var x = Math.Max(box.min.x, Math.Min(sphere.x, box.max.x));
            var y = Math.Max(box.min.y, Math.Min(sphere.y, box.max.y));
            var z = Math.Max(box.min.z, Math.Min(sphere.z, box.max.z));

            var distanceSqr = (x - sphere.x) * (x - sphere.x) +
                              (y - sphere.y) * (y - sphere.y) +
                              (z - sphere.z) * (z - sphere.z);

            return distanceSqr < sphere.radius * sphere.radius;
        }

        public static bool IsIntersect2D(Box2D box1, Box2D box2)
        {
            return (box1.min.x <= box2.max.x && box1.max.x >= box2.min.x) &&
                   (box1.min.y <= box2.max.y && box1.max.y >= box2.min.y);
        }

        public static bool IsIntersect2D(Point2D point, Box2D box)
        {
            return (point.position.x >= box.min.x && point.position.x <= box.max.x) &&
                   (point.position.y >= box.min.y && point.position.y <= box.max.y);
        }

        public static bool IsIntersect2D(Point2D point, Circle2D circle)
        {
            var distanceSqr = (point.position.x - circle.x) * (point.position.x - circle.x) +
                              (point.position.y - circle.y) * (point.position.y - circle.y);
            return distanceSqr < circle.radius * circle.radius;
        }

        public static bool IsIntersect2D(Circle2D circle1, Circle2D circle2)
        {
            var distanceSqr = (circle1.x - circle2.x) * (circle1.x - circle2.x) +
                              (circle1.y - circle2.y) * (circle1.y - circle2.y);
            return distanceSqr < (circle1.radius + circle2.radius) * (circle1.radius + circle2.radius);
        }

        public static bool IsIntersect2D(Circle2D circle2D, Box2D box)
        {
            var x = Math.Max(box.min.x, Math.Min(circle2D.x, box.max.x));
            var y = Math.Max(box.min.y, Math.Min(circle2D.y, box.max.y));

            var distanceSqr = (x - circle2D.x) * (x - circle2D.x) +
                              (y - circle2D.y) * (y - circle2D.y);

            return distanceSqr < circle2D.radius * circle2D.radius;
        }
    }
}