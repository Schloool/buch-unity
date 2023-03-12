using UnityEngine;

public class FindComponentTest : MonoBehaviour
{
    private void Start()
    {
        ConsolePrinter printer = FindObjectOfType<ConsolePrinter>();
        printer.PrintMessage();
    }
}