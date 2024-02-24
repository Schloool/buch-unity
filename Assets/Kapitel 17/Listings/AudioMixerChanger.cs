using UnityEngine;
using UnityEngine.Audio;

public class AudioMixerChanger : MonoBehaviour
{
    [SerializeField] [Range(-30f, 0f)] private float volume;
    [SerializeField] private AudioMixer mixerGroup;

    private void Update()
    {
        mixerGroup.SetFloat("MusicVolume", volume);
    }
}
