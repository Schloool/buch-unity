using UnityEngine;

public class Bomb : MonoBehaviour, ISoundObject
{
    public float SoundVolume => 100f;
    
    private void Start()
    {
        Debug.Log("Ich bin eine Bombe");
    }
    
    void ISoundObject.MakeSound()
    {
        Debug.Log("BUMM");
    }
}