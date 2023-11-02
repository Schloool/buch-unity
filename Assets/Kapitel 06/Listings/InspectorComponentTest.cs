using UnityEngine;

public class InspectorComponentTest : MonoBehaviour
{
    public ConsolePrinter printer;
    
    private void Start()
    {
        printer.PrintMessage();
    }
}