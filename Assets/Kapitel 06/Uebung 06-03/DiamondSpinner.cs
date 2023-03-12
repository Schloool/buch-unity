using UnityEngine;
using UnityEngine.Serialization;

public class DiamondSpinner : MonoBehaviour
{
    [FormerlySerializedAs("spinSpeed")] public float speed;
    
    private void Update()
    {
        float input = Input.GetAxis("Horizontal");
        transform.eulerAngles += Vector3.up * input * speed * Time.deltaTime;
    }
}
