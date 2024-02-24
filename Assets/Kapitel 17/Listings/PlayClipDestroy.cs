using UnityEngine;

public class PlayClipDestroy : MonoBehaviour
{
    [SerializeField] private AudioClip clip;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AudioSource.PlayClipAtPoint(clip, transform.position);
            Destroy(gameObject);
        }
    }
}