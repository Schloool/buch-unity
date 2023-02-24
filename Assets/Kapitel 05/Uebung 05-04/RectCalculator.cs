using UnityEngine;

public class RectCalculator : MonoBehaviour
{
   private void Start()
   {
      float a = 20.5f;
      float b = 10.25f;
      
      Debug.Log($"Flächeninhalt: {CalculateArea(a, b)}");
      Debug.Log($"Umfang: {CalculateCircumference(a, b)}");
   }

   private float CalculateArea(float a, float b)
   {
      return a * b;
   }
   
   private float CalculateCircumference(float a, float b)
   {
      return 2 * (a + b);
   }
}