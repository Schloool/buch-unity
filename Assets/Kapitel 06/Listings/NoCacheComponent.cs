using UnityEngine;

public class NoCacheComponent : MonoBehaviour
{
    private void Update()
    {
        ConsolePrinter[] printers = FindObjectsOfType<ConsolePrinter>();
        
        foreach (ConsolePrinter printer in printers)
        {
            printer.PrintMessage();
        }
    }
}