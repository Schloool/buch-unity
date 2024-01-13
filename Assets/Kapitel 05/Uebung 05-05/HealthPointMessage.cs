using UnityEngine;

public class HealthPointMessage : MonoBehaviour
{
    private void PrintHealthPointOutput(int currentHP, int maxHP)
    {
        float hpRatio = (float) currentHP / maxHP;

        if (hpRatio < 0)
        {
            Debug.Log("Fehler: Weniger als 0 HP.");
        } 
        else if (Mathf.Approximately(hpRatio, 0f))
        {
            Debug.Log("Ich bin tot!");
        } 
        else if (hpRatio <= 0.3f)
        {
            Debug.Log("Nur noch wenig HP!");
        }
        else
        {
            Debug.Log("Alles im grünen Bereich.");
        }
    }
}