using UnityEngine;

public class InheritanceTest : MonoBehaviour
{
    private void Start()
    {
        Mammal mammal = new Mammal(10f);
        Cat cat = new Cat(5f, 150);
        
        mammal.Move();
        cat.Move();
     
        cat.Meow();
    }
}