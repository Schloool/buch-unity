using UnityEngine;

public abstract class Animal
{
    public abstract int LegAmount { get; }
    
    public abstract void Speak();

    public void PrintInfo()
    {
        Debug.Log("Ich bin ein Tier.");
    }
}