using System;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        string collidedName = collision.gameObject.name;
        Debug.Log($"{gameObject.name} kollidiert mit {collidedName}");
    }
}
