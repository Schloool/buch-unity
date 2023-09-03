using System.Collections.Generic;
using UnityEngine;

public class ListTest : MonoBehaviour
{
    [SerializeField] private List<string> inspectorList;
    
    private void Start()
    {
        List<int> myIntList = new List<int>();
        // List<int> myIntList = new List<int>() { 42, 5, 10 }; 
        
        int[] myIntArray = new int[] { 42, 5, 10 };
        myIntList.AddRange(myIntArray);
        
        Debug.Log(myIntArray[1]);

        myIntArray[1] = 15;
        for (int i = 0; i < myIntList.Count; i++)
        {
            Debug.Log(myIntList[i]);
        }
        
        foreach (int number in myIntList)
        {
            Debug.Log(number);
        }

        myIntList.Remove(42);
        
        myIntList.Clear();
    }
}
