using UnityEngine;

public class Button : ISoundObject
{
    public float SoundVolume => 5f;
    
    public void MakeSound()
    {
        Debug.Log("Klick");
    }
}