using Intersection;
using UnityEngine;

public class PlayerIntersection : MonoBehaviour
{
    [SerializeField] private Intersector _intersector;

    private void Start()
    {
        _intersector.Registrate();
        _intersector.Intersected += (x) => { print(x.name); };
    }
}
