using UnityEngine;

public class MicrophoneTest : MonoBehaviour
{
    private void Start()
    {
        string device = Microphone.devices[0];
        AudioClip clip = Microphone.Start(device, true, 3, 44000);

        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = clip;
        audioSource.Play();
    }
}
