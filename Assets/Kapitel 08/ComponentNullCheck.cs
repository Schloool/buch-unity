using UnityEngine;

public class ComponentNullCheck : MonoBehaviour
{
    private void Start()
    {
        ConsolePrinter printer = FindObjectOfType<ConsolePrinter>();
        if (printer == null)
        {
            Debug.Log("Kein ConsolePrinter gefunden!");
        }
        else
        {
            printer.PrintMessage();
        }
        
        FindObjectOfType<ConsolePrinter>()?.PrintMessage();
    }
}