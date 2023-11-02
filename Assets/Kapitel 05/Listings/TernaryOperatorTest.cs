using UnityEngine;

public class TernaryOperatorTest : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(GetTemperatureInfo(25.5f));
        Debug.Log(GetTemperatureInfo(-3f));
    }

    private string GetTemperatureInfo(float temperature)
    {
        return temperature > 20f ? "Warm" : "Kalt";
    }
}