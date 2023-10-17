using UnityEngine;

public class PlayClipDestroy : MonoBehaviour
{
    [SerializeField] private AudioClip clip;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AudioSource.PlayClipAtPoint(clip, Vector3.zero);
            Destroy(gameObject);
        }
    }
}