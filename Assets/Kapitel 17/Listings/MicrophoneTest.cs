using UnityEngine;

public class MicrophoneTest : MonoBehaviour
{
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Start()
    {
        string device = Microphone.devices[0];
        AudioClip clip = Microphone.Start(device, true, 3, 44000);

        audioSource.clip = clip;
        audioSource.Play();
    }
}
