using UnityEngine;

public class Person
{
    private string name;
    private uint age;

    public Person(string name, uint age)
    {
        this.name = name;
        this.age = age;
    }

    public Person()
    {
        name = "Unbekannt";
        age = 0;
    }

    public void Introduce()
    {
        Debug.Log($"Die Person {name} ist {age} Jahre alt.");
    }
}