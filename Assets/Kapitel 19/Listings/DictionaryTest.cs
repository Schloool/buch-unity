using System.Collections.Generic;
using UnityEngine;

public class DictionaryTest : MonoBehaviour
{
    private void Start()
    {
        Dictionary<string, int> myDict = new Dictionary<string, int>()
        {
            {"eins", 1},
            {"zwei", 2}
        };

        Debug.Log(myDict["eins"]);
        Debug.Log(myDict["fuenf"]);

        myDict["vier"] = 4;
        myDict["eins"] = 11;
        
        foreach (KeyValuePair<string,int> pair in myDict)
        {
            Debug.Log($"Schlüssel: {pair.Key}");
            Debug.Log($"Wert: {pair.Value}");
        }
        
        foreach (string key in myDict.Keys)
        {
            Debug.Log(key);
        }
    }
}