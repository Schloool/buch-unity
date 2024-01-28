using UnityEngine;

public class OverrideTest : MonoBehaviour
{
    private void Start()
    {
        Car car = new Car();
        Car truck = new Truck();
        
        car.Honk();
        truck.Honk();
    }
}