using UnityEngine;

public class ChildComponentTest : MonoBehaviour
{
    private void Start()
    {
        ConsolePrinter printer = GetComponentInChildren<ConsolePrinter>();
        printer.PrintMessage();
    }
}