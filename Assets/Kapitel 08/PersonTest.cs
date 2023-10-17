using UnityEngine;

public class PersonTest : MonoBehaviour
{
    private void Start()
    {
        Person max = new Person("Max", 22);
        Person lisa = new Person("Lisa", 21);

        max.Introduce();
        lisa.Introduce();
    }
}