using UnityEngine;

public class PersonConstructorTest : MonoBehaviour
{
    private void Start()
    {
        Person max = new Person("Max", 22);
        Person unknown = new Person();

        max.Introduce();
        unknown.Introduce();
        Debug.Log("A");
    }
}