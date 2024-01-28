using UnityEngine;

public class ConvertionTest : MonoBehaviour
{
    private void Start()
    {
        Mammal mammal = new Mammal(10f);
        Mammal cat = new Cat(5f, 150);
        
        TestConversionToCat(mammal);
        TestConversionToCat(cat);
    }

    private void TestConversionToCat(Mammal mammal)
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