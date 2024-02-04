using UnityEngine;

public class SoundInterfaceTest : MonoBehaviour
{
    [SerializeField] private Bomb bomb;
    
    private void Start()
    {
        SoundButton soundButton = new SoundButton();
        
        TestSoundObject(soundButton);
        TestSoundObject(bomb);
    }

    private void TestSoundObject(ISoundObject soundObject)
    {
        Debug.Log($"Lautstärke {soundObject.SoundVolume}");
        soundObject.MakeSound();
    }
}