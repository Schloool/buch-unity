using System;
using UnityEngine;

public class StringMethods : MonoBehaviour
{
    private void Start()
    {
        string text = "Hallo Welt!";
        
        Debug.Log(text.Contains("all"));
        Debug.Log(text.Contains("moin"));
        
        Debug.Log(text.Replace("Hallo", "Moin"));
        
        string[] split = text.Split(" ");
        Debug.Log(split[0]);
        Debug.Log(split[1]);
        
        Debug.Log(text.Substring(3));
        Debug.Log(text.Substring(3, 6));
        
        Debug.Log(text.Insert(3, "Tag"));

        string test = " Test ";
        Debug.Log(test.Trim());

        Debug.Log(text.Length);
    }
}