using UnityEngine;

public class CupTest : MonoBehaviour
{
    [SerializeField] private Cup[] cups;

    private void Start()
    {
        float volumeSum = 0;
        foreach (Cup cup in cups)
        {
            volumeSum += cup.CalculateVolume();
        }
        
        Debug.Log($"Gesamtes Volumen: {volumeSum} cm^3");
    }
}