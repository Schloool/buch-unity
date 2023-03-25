using UnityEngine;

public class SoundInterfaceTest : MonoBehaviour
{
    private void Start()
    {
        Button button = new Button();
        Bomb bomb = FindObjectOfType<Bomb>();
        
        TestSoundObject(button);
        TestSoundObject(bomb);
    }

    private void TestSoundObject(ISoundObject soundObject)
    {
        Debug.Log($"Lautstärke {soundObject.SoundVolume}");
        soundObject.MakeSound();
    }
}