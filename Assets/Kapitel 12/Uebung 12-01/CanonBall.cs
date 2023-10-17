using UnityEngine;

public class CanonBall : MonoBehaviour
{
    [SerializeField] private float speed;
    
    public Vector3 Direction { get; set; }

    private void Update()
    {
        transform.position += Direction * speed * Time.deltaTime;
    }
}
