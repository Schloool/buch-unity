using UnityEngine;

public class NamedParameterTest : MonoBehaviour
{
    private void Start()
    {
        TestMethod(5, "Hallo");
        TestMethod(myString: "Moin", myInt: 10);
    }

    private void TestMethod(int myInt, string myString)
    {
        Debug.Log($"{myInt}, {myString}");
    }
}