using UnityEngine;

public class OverrideTest : MonoBehaviour
{
    private void Start()
    {
        Car car = new Car();
        car.Honk();
        
        car = new Truck();
        car.Honk();
    }
}