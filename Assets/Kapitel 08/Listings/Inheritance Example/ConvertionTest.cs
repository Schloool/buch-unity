using UnityEngine;

public class ConvertionTest : MonoBehaviour
{
    private void Start()
    {
        Mammal mammal = new Mammal(10f);
        Mammal cat = new Cat(5f, 150);
        
        TestCatConversion(mammal);
        TestCatConversion(cat);
    }

    private void TestCatConversion(Mammal mammal)
    {
        if (mammal is Cat cat)
        {
            cat.Meow();
        }
        else
        {
            Debug.Log("Keine Katze!");
        }
    }
}