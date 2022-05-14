using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        print(other.name);
    }
}
