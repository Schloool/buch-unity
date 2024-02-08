using UnityEngine;

public class AntiGravityPrefabs : MonoBehaviour
{
    [SerializeField] private Rigidbody[] rigidbodies;

    private void Start()
    {
        for (int i = 0; i < rigidbodies.Length; i++)
        {
            Rigidbody newRigidbody = Instantiate(rigidbodies[i], Vector3.zero, Quaternion.identity, transform);
            newRigidbody.gameObject.name = $"Objekt {i + 1}";
            newRigidbody.useGravity = false;
        }
    }
}