using UnityEngine;

public class AudioSwitcher : MonoBehaviour
{
    [SerializeField] private AudioClip[] clips;

    private AudioSource audioSource;
    
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        audioSource.clip = clips[Random.Range(0, clips.Length)];
        audioSource.Play();
    }
}