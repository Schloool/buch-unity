using UnityEngine;

public class TableTest : MonoBehaviour
{
    private void Start()
    {
        Table table = new Table(4);
        Debug.Log(table);

        Table b = new Table(4);
        Debug.Log(table.Equals(b));
    }
}