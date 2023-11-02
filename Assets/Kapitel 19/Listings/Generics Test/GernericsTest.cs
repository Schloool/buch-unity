using UnityEngine;

public class GernericsTest : MonoBehaviour
{
    private void Start()
    {
        StringPair pair1 = new StringPair("Eintrag 1", "Eintrag 2");

        Pair<string> stringPair = new Pair<string>("Eintrag 1", "Eintrag 2");
        Pair<int> intPair = new Pair<int>(1, 5);

        MultiPair<string, int> pair = new MultiPair<string, int>("Test", 1);

        ConstraintTest<GenericDummy> dummy = new ConstraintTest<GenericDummy>();
        dummy.Test(FindObjectOfType<GenericDummy>());

        NewConstraintTest<int> newConstraintTest;
    }

    public static void Test<T>(T component) where T : MonoBehaviour
    {
        Debug.Log($"Name des Objekts: {component.gameObject.name}");
    }
}