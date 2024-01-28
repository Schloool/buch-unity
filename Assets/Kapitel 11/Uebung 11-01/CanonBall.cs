using UnityEngine;
using UnityEngine.Serialization;

public class CanonBall : MonoBehaviour
{
    [SerializeField] private float speed;

    public Vector3 direction;

    private void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
