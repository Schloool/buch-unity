using UnityEngine;

public class Cat : Mammal
{
    private int whiskers;
    
    public Cat(float speed, int whiskers) : base(speed)
    {
        this.whiskers = whiskers;
    }

    public void Meow()
    {
        Debug.Log($"Miau! Ich habe {whiskers} Schnurrhaare.");   
    }
}