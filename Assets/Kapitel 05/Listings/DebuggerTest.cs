using UnityEngine;

public class DebuggerTest : MonoBehaviour
{

    void Start()
    {
        int[] myInts = { 1, 2, 5 };
        Debug.Log(myInts[3]);
    }
}