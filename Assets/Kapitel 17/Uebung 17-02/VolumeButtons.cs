using UnityEngine;

public class VolumeButtons : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            audioSource.volume = Mathf.Clamp01(audioSource.volume + 0.1f);
        }
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            audioSource.volume = Mathf.Clamp01(audioSource.volume - 0.1f);
        }
    }
}