using UnityEngine;

public class OptionalParameterTest : MonoBehaviour
{
    private void Start()
    {
        TestMethod(10);
        TestMethod(10, "Hallo");
        TestMethod(myString: "Moin", myInt: 20);
    }

    private void TestMethod(int myInt, string myString = "Beispiel")
    {
        Debug.Log($"{myInt}, {myString}");
    }
}