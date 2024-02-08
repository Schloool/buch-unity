using System.Collections;
using UnityEngine;

public class FramedCoroutine : MonoBehaviour
{
    [SerializeField] private int messageFrameCount;
    
    private IEnumerator Start()
    {
        int frames = 0;
        while (!Input.GetKeyDown(KeyCode.Space))
        {
            frames++;
            if (frames == messageFrameCount)
            {
                Debug.Log($"{messageFrameCount} Frames vorbei.");
                frames = 0;
            }
            
            yield return null;
        }

        Debug.Log("Leertaste gedrückt, das Zählen endet!");
    }
}