using UnityEngine;

public class SwitchReturnTest : MonoBehaviour
{
    private void Start()
    {
        int x = Random.Range(-5, 5);
        Debug.Log(GetNumberMessage(x));
    }

    private string GetNumberMessage(int number)
    {
        switch (number)
        {
            case 0:
                return "x ist 0";
            
            case 1: case 2:
                return "x ist 1 oder 2";
            
            default:
                return "x besitzt einen Wert < 0 oder > 2";
        }
    }
}