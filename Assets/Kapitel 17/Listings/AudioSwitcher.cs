using UnityEngine;

public class AudioSwitcher : MonoBehaviour
{
    [SerializeField] private AudioClip[] clips;

    private void Start()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = clips[Random.Range(0, clips.Length)];
        
        audioSource.Play();
    }
}