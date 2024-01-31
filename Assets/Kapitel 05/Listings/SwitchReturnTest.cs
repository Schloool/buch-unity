using UnityEngine;

public class SwitchReturnTest : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(PrintSeasonToIndex(0));
    }
    
    private string PrintSeasonToIndex(int index)
    {
        switch (index)
        {
            case 0:
                return "Frühling";
            
            case 1:
            case 2:
                return "Sommer oder Herbst";
            
            case 3:
                return "Winter";
            
            default:
                return "Unbekannte Jahreszeit!";
        }
    }
}