using Unity.VisualScripting;
using UnityEngine;

public class Truck : Car
{
    public override void Honk()
    {
        Debug.Log("TRÖÖÖT!");
    }
}