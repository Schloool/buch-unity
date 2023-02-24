using UnityEngine;

public class FruitCollection : MonoBehaviour
{
    private void Start()
    {
        string[] fruit = { "Apfel", "Kirsche", "Erdbeere" };
        
        Debug.Log(fruit[0]);
        Debug.Log(fruit[2]);

        fruit[1] = "Birne";
        Debug.Log(fruit[1]);
    }
}