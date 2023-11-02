using UnityEngine;

public class GetComponentTest : MonoBehaviour
{
    private void Start()
    {
        ConsolePrinter printer = GetComponent<ConsolePrinter>();
        printer.PrintMessage();
    }
}