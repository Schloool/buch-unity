using UnityEngine;

public class SwitchTest : MonoBehaviour
{
    private void Start()
    {
        PrintSeasonToIndex(0);
        PrintSeasonToIndex(2);
        PrintSeasonToIndex(7);
    }
    
    private void PrintSeasonToIndex(int index)
    {
        switch (index)
        {
            case 0:
                Debug.Log("Frühling");
                break;
            
            case 1:
            case 2:
                Debug.Log("Sommer oder Herbst");
                break;
            
            case 3:
                Debug.Log("Winter");
                break;
            
            default:
                Debug.Log("Unbekannte Jahreszeit!");
                break;
        }
    }
}