using System.Collections.Generic;
using UnityEngine;

namespace Intersection
{
    public class IntersectionSystem : MonoBehaviour
    {
        private static List<PointIntersector> _points = new List<PointIntersector>();
        private static List<SphereIntersector> _spheres = new List<SphereIntersector>();
        private static List<BoxIntersector> _boxes = new List<BoxIntersector>();

        private static List<Intersector> _activeIntersectors = new List<Intersector>();

        public static void Add(PointIntersector point) //make non-static with singleton
        {
            _points.Add(point);
        }

        public static void Add(SphereIntersector sphere)
        {
            _spheres.Add(sphere);
        }

        public static void Add(BoxIntersector box)
        {
            _boxes.Add(box);
        }

        public static void Registrate(Intersector intersector)
        {
            _activeIntersectors.Add(intersector);
        }

        private void Update()
        {
            XY(_activeIntersectors, _boxes);
            XY(_activeIntersectors, _spheres);
            XY(_activeIntersectors, _points);
        }

        private void XY<TX, TY>(List<TX> x, List<TY> y) where TX : Intersector where TY : Intersector
        {
            if (y.Count == 0 || x.Count == 0)
            {
                return;
            }

            for (int i = 0; i < x.Count; i++)
            {
                for (int j = 0; j < y.Count; j++)
                {
                    if (x[i].IntersectWithY(y[j]))
                    {
                        if(!x[i].Equals(y[j]))
                            x[i].Intersect(y[j]);
                    }
                }
            }
        }
    }
}