using UnityEngine;

public class CacheComponent : MonoBehaviour
{
    private ConsolePrinter[] printers;

    private void Start()
    {
        printers = FindObjectsOfType<ConsolePrinter>();
    }

    private void Update()
    {
        foreach (ConsolePrinter printer in printers)
        {
            printer.PrintMessage();
        }
    }
}