using UnityEngine;

public class SoundButton : ISoundObject
{
    public float SoundVolume => 5f;
    
    public void MakeSound()
    {
        Debug.Log("Klick");
    }
}