using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class KeyboardTone : MonoBehaviour
{
    private AudioSource audioSource;
    
    [SerializeField] private List<KeyCode> keys;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (!keys.Any(Input.GetKeyDown)) return;
        
        KeyCode pressedKey = keys.FirstOrDefault(Input.GetKeyDown);
        int keyIndex = keys.IndexOf(pressedKey);

        audioSource.pitch = Mathf.Lerp(1, 3f, (float)keyIndex / keys.Count);
        audioSource.Play();
    }
}