using UnityEngine;

public class TryGetComponentTest : MonoBehaviour
{
    private void Start()
    {
        if (TryGetComponent(out ConsolePrinter printer))
        {
            printer.PrintMessage();
        }
    }
}