using UnityEngine;

public class ChairTest : MonoBehaviour
{
    private void Start()
    {
        Chair chairA = new Chair();
        chairA.legAmount = 4;
        chairA.heightInMeters = 1.2f;
        chairA.sitLengthInCm = 50f;
        
        Chair chairB = new Chair();
        chairB.legAmount = 4;
        chairB.heightInMeters = 1.45f;
        chairB.sitLengthInCm = 35f;
        
        Debug.Log(chairA.CalculateSitArea());
        Debug.Log(chairB.CalculateSitArea());
    }
}