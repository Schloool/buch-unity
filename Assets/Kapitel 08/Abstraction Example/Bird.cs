using UnityEngine;

public class Bird : Animal
{
    public override int LegAmount => 2;

    public override void Speak()
    {
        Debug.Log("Piep!");
    }
}