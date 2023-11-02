using UnityEngine;

public class NewConstraintTest<T> where T : new() 
{
    public void Test()
    {
        T newInstance = new T();
    }
}