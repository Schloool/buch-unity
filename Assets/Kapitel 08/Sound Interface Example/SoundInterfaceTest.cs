using UnityEngine;

public class SoundInterfaceTest : MonoBehaviour
{
    private void Start()
    {
        SoundButton soundButton = new SoundButton();
        Bomb bomb = FindObjectOfType<Bomb>();
        
        TestSoundObject(soundButton);
        TestSoundObject(bomb);
    }

    private void TestSoundObject(ISoundObject soundObject)
    {
        Debug.Log($"Lautstärke {soundObject.SoundVolume}");
        soundObject.MakeSound();
    }
}