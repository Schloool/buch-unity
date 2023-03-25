using UnityEngine;

public class AbstractionTest : MonoBehaviour
{
    private void Start()
    {
        Bird bird = new Bird();
        Dog dog = new Dog();
        
        bird.PrintInfo();
        dog.PrintInfo();
        
        Debug.Log(bird.LegAmount);
        Debug.Log(dog.LegAmount);
        
        TestAnimal(bird);
        TestAnimal(dog);
    }

    private void TestAnimal(Animal animal)
    {
        animal.Speak();
    }
}