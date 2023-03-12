using UnityEngine;

public class InspectorComponentsTest : MonoBehaviour
{
    public ConsolePrinter[] printers;
    
    private void Start()
    {
        foreach (ConsolePrinter printer in printers)
        {
            printer.PrintMessage();
        }
    }
}