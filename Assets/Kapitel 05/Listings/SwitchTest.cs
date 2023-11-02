using UnityEngine;

public class SwitchTest : MonoBehaviour
{
    private void Start()
    {
        int x = Random.Range(-5, 5);
        switch (x)
        {
            case 0:
                Debug.Log("x ist 0");
                break;
            
            case 1: case 2:
                Debug.Log("x ist 1 oder 2");
                break;
            
            default:
                Debug.Log("x besitzt einen Wert < 0 oder > 2");
                break;
        }
    }
}