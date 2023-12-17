using UnityEngine;

public class PointCountSound : MonoBehaviour
{
    private AudioSource audioSource;
    private PointCounter pointCounter;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        pointCounter = FindObjectOfType<PointCounter>();
        pointCounter.OnUpdatePoints += HandlePointUpdate;
    }

    private void OnDestroy()
    {
        pointCounter.OnUpdatePoints -= HandlePointUpdate;
    }

    private void HandlePointUpdate(int points)
    {
        audioSource.Play();
    }
}