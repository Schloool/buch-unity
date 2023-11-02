using UnityEngine;

public class Dog : Animal
{
    public override int LegAmount => 4;

    public override void Speak()
    {
        Debug.Log("Wuff!");
    }
}